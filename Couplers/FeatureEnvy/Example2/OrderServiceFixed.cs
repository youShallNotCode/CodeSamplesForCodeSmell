/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class OrderService
{
    public decimal CalculateOrderTotal(Order order)
    {
        return order.GetTotalAmount();
    }
}