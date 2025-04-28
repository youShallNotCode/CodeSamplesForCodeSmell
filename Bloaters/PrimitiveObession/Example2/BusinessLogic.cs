//somewhere in code 
if (order.CurrencyCode == "USD")
	Console.WriteLine($"${order.Amount}");
else if (order.CurrencyCode == "EUR")
	Console.WriteLine($"{order.Amount}€");