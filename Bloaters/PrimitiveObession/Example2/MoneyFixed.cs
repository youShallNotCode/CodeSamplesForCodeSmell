/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class Money
{
	public decimal Amount { get; }
	public Curreny Curreny { get; }

	public Money(decimal amount, Currency currency)
	{
		//validation comes here
		Amount = amount;
		Currency = currency
	}

	public override string ToString()
	{
		return Currency.Symbol + Amount.ToString("F2");
	}
}