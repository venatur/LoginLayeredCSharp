using Npgsql;

namespace Persistencia
{
    public abstract class ConnectionPSQL
    {
        private readonly string connectionString;
        public ConnectionPSQL()
        {
            connectionString = "Host=localhost;Username=postgres;Password=12345;Database=manpower";

        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

    }
}
