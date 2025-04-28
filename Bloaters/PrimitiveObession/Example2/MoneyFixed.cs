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