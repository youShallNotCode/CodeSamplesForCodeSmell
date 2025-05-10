/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class OrderProcess
{
    public decimal CalculateTotal(Order order)
    {
        decimal total = order.Subtotal;

        // change #1 Tax calculation logic (modifed when there is new change)
        if (order.Country == "US")
            total += order.Subtotal * 0.07m;
        else if (order.Country == "EU")
            total += order.Subtotal * 0.20m;
        
        // change #2 added during promotion events
        if (order.IsPremiumUser)
            total *= 0.90m;
        
        return total;
    }

    public string GenerateShippingLabel(Order order)
    {
        // change #3 shipping rules modified when contract changes
        if(order.Weight > 20)
            return "ShippingProvider3";
        else
            return "ShippingProvider2";
    }

    public void ProcessPayment(Order order)
    {
        // change #4 Payment Processing modified when switching providers
        if (order.PaymentMethod == "PayPal")
            PayPalClient.Process(order.Total);
        else
            CreditCardProcessor.Charge(order.Total);
    }
}