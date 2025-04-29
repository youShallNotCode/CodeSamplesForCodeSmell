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