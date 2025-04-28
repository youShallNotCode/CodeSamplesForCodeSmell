public class OrderService
{
    public decimal CalculateOrderTotal(Order order)
    {
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.Price * item.Quantity;
        }

        total += order.ShippingCost;

        return total;
    }
}