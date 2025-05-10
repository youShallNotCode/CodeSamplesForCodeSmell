/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class ReportGenerator
{
    public void GenerateReportTimeStamp()
    {
        DateTime now = DateTime.Now;
        now.ToString("HH:mm"); //used in some internalLogic
        //code to generate report GenerateReportTimeStamp
    }
}