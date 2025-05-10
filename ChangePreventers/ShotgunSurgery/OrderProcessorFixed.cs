/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class OrderProcessor
{
    public string GetOrderTime()
    {
        DateTime now = DateTime.Now;
        return now.ToStandardTimeFormat();
    }
}