/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class DbConnectionSettings
{
    public string Server;
    public string Database;
    public string User;
    public string Password;
    public int Port;
    public bool UseSSL;
}

void OpenDbConnection(DbConnectionSettings settings)
{
    //Open Connection
}

void LogDbError(DbConnectionSettings settings, string error)
{
    //Log error
}

void RetryDbConnection(DbConnectionSettings settings, int retryCount)
{
    //retry logic
}