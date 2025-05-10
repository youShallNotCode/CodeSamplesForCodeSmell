/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class Currency
{
	public string Code { get; }
	public string Symbol { get; }

	private Currency(string code, string symbol)
	{
		Code = code;
		Symbol = symbol;
	}

	public static readonly Curreny USD = new ("USD", "$");
	public static readonly Curreny EUR = new ("EUR", "€");
	public static readonly Curreny INR = new ("INR", "₹");
	//Add more as needed
}