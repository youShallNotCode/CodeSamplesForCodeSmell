//somewhere in code
var connectionSettings = new DbConnectionSettings
{
    Server = "localhost",
    Database = "SalesDB",
    User = "admin",
    Password = "1234",
    Port = 1433,
    UseSSL = true
}

OpenDbConnection(connectionSettings);

LogDbError(connectionSettings, "Timeout expired");

RetryDbConnection(connectionSettings, 3);