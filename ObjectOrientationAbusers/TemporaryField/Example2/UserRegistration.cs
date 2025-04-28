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