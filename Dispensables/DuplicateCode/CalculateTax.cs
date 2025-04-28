public class CalculateTax
{
    public double CalculateTaxForOnlineOrder(Order order)
    {
        return order.amount * 0.15;
    }

    public double CalculateTaxForStoreOrder(Order order)
    {
        return order.amount * 0.15;
    }
}