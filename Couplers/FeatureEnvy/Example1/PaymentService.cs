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