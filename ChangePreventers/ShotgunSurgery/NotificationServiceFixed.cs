/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class NotificationService
{
    public void CreateNotification()
    {
        DateTime now = DateTime.Now;
        string timeNow = now.ToStandardTimeFormat(); //used in some internalLogic
        //code to CreateNotification
    }
}