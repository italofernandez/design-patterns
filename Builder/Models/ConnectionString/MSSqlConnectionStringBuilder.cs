namespace Builder.Models.ConnectionString
{
    public class MSSqlConnectionStringBuilder : IConnectionStringBuilder
    {
        private const string connectionString = @"Server={0};Database={1};User Id={2};Password={3};";
        private string serverAddress;
        private string serverAddressPort;
        private string databaseName;
        private string username;
        private string password;

        public string Build()
        {
            if (!string.IsNullOrEmpty(serverAddressPort))
                serverAddress += $",{serverAddressPort}";
            return string.Format(connectionString, serverAddress, databaseName, username, password);
        }

        public void Reset()
        {
            serverAddress = string.Empty;
            databaseName = string.Empty;
            username = string.Empty;
            password = string.Empty;
        }

        public IConnectionStringBuilder WithCredentials(string username, string password)
        {
            this.username = username;
            this.password = password;
            return this;
        }

        public IConnectionStringBuilder WithDatabaseName(string databaseName)
        {
            this.databaseName = databaseName;
            return this;
        }

        public IConnectionStringBuilder WithPort(string addressPort)
        {
            this.serverAddressPort = addressPort;
            return this;
        }

        public IConnectionStringBuilder WithServerAddress(string serverAddress)
        {
            this.serverAddress = serverAddress;
            return this;
        }
    }
}
