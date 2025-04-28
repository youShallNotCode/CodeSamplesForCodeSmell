public class OrderProcess
{
    public decimal CalculateTotal(Order order)
    {
        decimal total = order.Subtotal;

        if (order.Country == "US")
            total += order.Subtotal * 0.05m;
        else if (order.Country == "EU")
            total += order.Subtotal * 0.25m;
        
        if (order.IsPremiumUser)
            total *= 0.10m;
        
        return total;
    }

    public string GenerateShippingLabel(Order order)
    {
        if(order.Weight > 20)
            return "ShippingProvider1";
        else
            return "ShippingProvider2";
    }

    public void ProcessPayment(Order order)
    {
        if (order.PaymentMethod == "Stripe")
            Stripe.Process(order.Total);
        else
            CreditCardProcessor.Charge(order.Total);
    }
}