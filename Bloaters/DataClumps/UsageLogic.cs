OpenDbConnection("localhost","SalesDB","admin","password123",
                        1433,true)

LogDbError("localhost","SalesDB","admin","password123",
                        1433,true,"Timeout expired")

RetryDbConnection("localhost","SalesDB","admin","password123",
                        1433,true, 3)