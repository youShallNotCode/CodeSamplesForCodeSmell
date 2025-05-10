/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class Transaction
{
    public decimal Amount { get; set; }
    public decimal Tax { get; set; }
    public decimal Discount { get; set; }
}

public class PaymentService
{
    public decimal CalculateTotal(Transaction transcation)
    {
        return transcation.Amount + transcation.Tax - transcation.Discount;
    }
}