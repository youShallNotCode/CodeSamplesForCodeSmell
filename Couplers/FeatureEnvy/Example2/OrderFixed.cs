public class Order
{
    private List<OrderItem> items { get; set; }
    private decimal shippingCost { get; set; }

    public decimal GetTotalAmount()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.GetTotalPrice();
        }

        return total + shippingCost;
    }
}