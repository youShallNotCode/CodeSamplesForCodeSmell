/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class Transaction
{
    private decimal amount { get; set; }
    private decimal tax { get; set; }
    private decimal discount { get; set; }

    public decimal GetTotalAmount()
    {
        return amount + tax - discount;
    }
}

public class PaymentService
{
    public decimal CalculateTotal(Transaction transcation)
    {
        return transcation.GetTotalAmount();
    }
}