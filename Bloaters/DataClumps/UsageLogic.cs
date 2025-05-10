/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

OpenDbConnection("localhost","SalesDB","admin","password123",
                        1433,true)

LogDbError("localhost","SalesDB","admin","password123",
                        1433,true,"Timeout expired")

RetryDbConnection("localhost","SalesDB","admin","password123",
                        1433,true, 3)