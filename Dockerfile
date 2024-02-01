FROM liquibase/liquibase

WORKDIR /liquibase

# Install required tools
#RUN apt-get update && apt-get install -y wget

ARG LIQUIBASE_VERSION=4.25.1

RUN wget "https://github.com/liquibase/liquibase-cassandra/releases/download/untagged-267bb44cdeb2c2d645b1/liquibase-cassandra-${LIQUIBASE_VERSION}.jar" -O lib/liquibase-cassandra.jar
RUN wget "https://github.com/ing-bank/cassandra-jdbc-wrapper/releases/download/v4.11.1/cassandra-jdbc-wrapper-4.11.1-bundle.jar" -O lib/liquibase-jdbc-cassandra.jar

# Copy the scripts to the container
COPY ./cassandra /liquibase/scripts

# Set the PATH environment variable to include Liquibase
ENV PATH="/liquibase:${PATH}"

RUN liquibase --classpath=/liquibase/lib/liquibase-cassandra.jar:/liquibase/lib/liquibase-jdbc-cassandra.jar \
              --changeLogFile=/scripts/local.changelog-root.xml \
              --defaultsFile=/scripts/liquibase.properties \
              --url="jdbc:cassandra://localhost:9042/voicevista" \
              --logLevel=debug \
              update