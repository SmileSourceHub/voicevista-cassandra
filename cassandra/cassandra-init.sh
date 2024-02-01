CQL="CREATE KEYSPACE IF NOT EXISTS voicevista WITH replication = {'class': 'SimpleStrategy', 'replication_factor': '1'} AND durable_writes = true;"

until echo $CQL | cqlsh
do
	now=$(date +%T)
	echo "[$now INIT CQLSH]: Node still unavailable, will retry another time"
	sleep 2
done &

echo "Done creating default keyspace."

exec /usr/local/bin/docker-entrypoint.sh "$@"