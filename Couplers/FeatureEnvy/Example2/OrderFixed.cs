public class Order
{
    public List<OrderItem> Items { get; set; }
    public decimal ShippingCost { get; set; }

    public decimal GetTotalAmount()
    {
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.GetTotalPrice();
        }

        return total + ShippingCost;
    }
}