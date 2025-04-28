class Email
{
	public string Value { get; }
	
	public Email(string value)
	{
		//validation logic (throws ex)
		Value = value;
	}

	public override string ToString() => Value;
}