namespace Builder.Models.ConnectionString.Builders.Interfaces
{
    public interface IConnectionStringBuilder : IBuilder<string>
    {
        IConnectionStringBuilder WithDatabaseName(string databaseName);
        IConnectionStringBuilder WithCredentials(string username, string password);
        IConnectionStringBuilder WithServerAddress(string serverAddress);
        IConnectionStringBuilder WithPort(string addressPort);
    }
}
