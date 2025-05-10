/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

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