using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models.ConnectionString
{
    public class MongoDbConnectionStringBuilder : IConnectionStringBuilder
    {
        private const string connectionString = @"mongodb://{0}:{1}@{2}";
        private string serverAddress;
        private string serverAddressPort;
        private string username;
        private string password;

        public string Build()
        {
            if (!string.IsNullOrEmpty(serverAddressPort))
                serverAddress += $":{serverAddressPort}";
            return string.Format(connectionString, username, password, serverAddress, serverAddressPort);
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
            throw new NotImplementedException();
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
