CREATE TABLE IF NOT EXISTS voicevista.servers (
    serverid BIGINT PRIMARY KEY,
    name text,
    categoryLists list<BIGINT>,
    channelLists list<BIGINT>
);
CREATE TABLE IF NOT EXISTS voicevista.messages (
    messageid BIGINT,
    content text,
    user text,
    channelid BIGINT,
    PRIMARY KEY (messageid, channelid)
);
CREATE TABLE IF NOT EXISTS voicevista.categories (
    categoryid BIGINT PRIMARY KEY,
    name text
);
CREATE TABLE IF NOT EXISTS voicevista.channels (
    channelid BIGINT PRIMARY KEY,
    name text
);