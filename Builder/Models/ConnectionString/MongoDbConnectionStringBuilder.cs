using Builder.Models.ConnectionString.Builders.Interfaces;

namespace Builder.Models.ConnectionString
{
    public class MongoDbConnectionStringBuilder : IConnectionStringBuilder
    {
        private const string connectionString = @"mongodb://{0}:{1}@{2}{3}";
        private string serverAddress;
        private string serverAddressPort;
        private string username;
        private string password;
        private string authSource;

        public string Build()
        {
            if (!string.IsNullOrEmpty(serverAddressPort))
                serverAddress += $":{serverAddressPort}";
            return string.Format(connectionString, username, password, serverAddress, authSource);
        }

        public void Reset()
        {
            serverAddress = string.Empty;
            serverAddressPort = string.Empty;
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
            if(!string.IsNullOrEmpty(databaseName))
                authSource = $"?authSource={databaseName}";

            return this;
        }

        public IConnectionStringBuilder WithServerAddress(string serverAddress)
        {
            this.serverAddress = serverAddress;
            return this;
        }

        public IConnectionStringBuilder WithPort(string addressPort)
        {
            serverAddressPort = addressPort;
            return this;
        }
    }
}
