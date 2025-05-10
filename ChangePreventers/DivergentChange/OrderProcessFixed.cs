/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class OrderProcess
{
    //rest of the code initialization etc
    public void ProcessOrder()
    {
        decimal total = new OrderCalculator().CalculateTotal(order);
        string label = new ShippingService().GenerateLabel(order);
        new ProcessPayment().ProcessPayment(order);
    }
}