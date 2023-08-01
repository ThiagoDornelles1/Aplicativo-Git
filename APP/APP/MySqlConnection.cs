namespace SuaApi
{
    internal class MySqlConnection
    {
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}