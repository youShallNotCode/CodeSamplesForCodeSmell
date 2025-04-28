public class OrderProcessor
{
    public string GetOrderTime()
    {
        DateTime now = DateTime.Now;
        return now.ToString("HH:mm");
    }
}