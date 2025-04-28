abstract class Notifier
{
    void Notify(string username);
    
    public string GenerateCode() => Guid.NewGuid().ToString().Substring(0,6);
}

//EmailNotifier.cs

class EmailNotifier : Notifier
{
    public void Notify(string username)
    {
        var code = base.GenerateCode();
        //Email logic
    }
}

//SMSNotifier.cs

class SMSNotifier : Notifier
{
    public void Notify(string username)
    {
        var code = base.GenerateCode();
        //SMS logic
    }
}