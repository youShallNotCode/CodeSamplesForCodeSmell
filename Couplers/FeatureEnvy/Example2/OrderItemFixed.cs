public class OrderItem
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal GetTotalPrice()
    {
        return Price * Quantity;
    }
}