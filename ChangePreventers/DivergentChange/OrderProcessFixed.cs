public class OrderProcess
{
    //rest of the code initialization etc
    public void ProcessOrder()
    {
        decimal total = new OrderCalculator().CalculateTotal(order);
        string label = new ShippingService().GenerateLabel(order);
        new ProcessPayment().ProcessPayment(order);
    }
}