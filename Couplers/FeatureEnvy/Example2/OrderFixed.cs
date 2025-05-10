/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class Order
{
    private List<OrderItem> items { get; set; }
    private decimal shippingCost { get; set; }

    public decimal GetTotalAmount()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.GetTotalPrice();
        }

        return total + shippingCost;
    }
}