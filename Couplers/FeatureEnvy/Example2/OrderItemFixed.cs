public class OrderItem
{
    private decimal price { get; set; }
    private int quantity { get; set; }

    public decimal GetTotalPrice()
    {
        return price * quantity;
    }
}