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