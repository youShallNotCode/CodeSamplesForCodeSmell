class PhoneNumber
{
	public string Value { get; }
	
	public PhoneNumber(string value)
	{
		//validation logic (throws ex)
		Value = value;
	}

	public override string ToString() => Value;
}