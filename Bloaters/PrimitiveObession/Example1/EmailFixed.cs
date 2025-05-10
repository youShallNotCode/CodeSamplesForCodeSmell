/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

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