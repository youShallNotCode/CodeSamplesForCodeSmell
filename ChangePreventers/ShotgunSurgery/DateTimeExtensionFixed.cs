public static class DateTimeExtensions
{
    public static string ToStandardTimeFormat(this DateTime time)
    {
        return time.ToString("HH:mm");
    }
}