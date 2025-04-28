//somewhere in code
void OpenDbConnection(string server, string database, string user, 
             string password,int port, bool useSSL)
{
    //Open Connection
}

void LogDbError(string server, string database, string user, 
             string password,int port, bool useSSL, string error)
{
    //log error
}

void RetryDbConnection(string server, string database, string user, 
             string password,int port, bool useSSL, int retryCount)
{
    // retry logic
}