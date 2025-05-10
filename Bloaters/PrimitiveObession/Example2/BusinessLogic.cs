/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

//somewhere in code 
if (order.CurrencyCode == "USD")
	Console.WriteLine($"${order.Amount}");
else if (order.CurrencyCode == "EUR")
	Console.WriteLine($"{order.Amount}€");