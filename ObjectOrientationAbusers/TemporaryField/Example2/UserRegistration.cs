/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class UserRegistration
{
    private string emailVerificationCode;
    private string smsVerificationCode;
    private bool sendEmail;
    private bool sendSMS;

    public void RegisterUser(string username, bool sendEmail, bool sendSMS)
    {
        this.sendEmail = sendEmail;
        this.sendSMS = sendSMS;

        if (sendEmail)
        {
            emailVerificationCode = GenerateCode();
            SendEmail(username, emailVerificationCode);
        }

        if (sendSMS)
        {
            smsVerificationCode = GenerateCode();
            sendSMS(username, emailVerificationCode);
        }

        SaveToDatabase(username);
    }

    private string GenerateCode() => Guid.NewGuid().ToString().Substring(0,6);

    private void SendEmail(string username, string code)
    {
        //Email logic
    }

    private void SendSMS(string username, string code)
    {
        //SMS logic
    }

    private void SaveToDatabase(string username)
    {
        //DB logic
    }
}