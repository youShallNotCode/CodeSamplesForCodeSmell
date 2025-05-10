/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

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