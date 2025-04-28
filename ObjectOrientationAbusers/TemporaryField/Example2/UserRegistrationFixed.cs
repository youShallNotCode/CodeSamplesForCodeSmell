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