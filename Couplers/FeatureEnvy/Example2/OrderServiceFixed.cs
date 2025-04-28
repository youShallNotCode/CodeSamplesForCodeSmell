public class OrderService
{
    public decimal CalculateOrderTotal(Order order)
    {
        return order.GetTotalAmount();
    }
}