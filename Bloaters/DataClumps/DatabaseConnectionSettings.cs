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