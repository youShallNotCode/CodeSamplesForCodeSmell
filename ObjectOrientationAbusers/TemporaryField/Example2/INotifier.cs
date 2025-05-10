/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

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