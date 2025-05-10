/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class UserRegistration
{
    public void RegisterUser(string username, bool sendEmail = false, bool sendSMS = false)
    {
        if (sendEmail) new EmailNotifier().Notify(username);

        if (sendSMS) new SMSNotifier().Notify(username);

        SaveToDatabase(username);
    }

    private SaveToDatabase(string username)
    {
        //save to db
    }
}