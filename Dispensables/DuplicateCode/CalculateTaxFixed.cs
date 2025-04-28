public class CalculateTax
{
    public double CalculateTaxForOrder(Order order)
    {
        return order.amount * 0.15;
    }
}