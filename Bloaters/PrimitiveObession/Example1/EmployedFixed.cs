/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class Employed
{
	var user = new User
	{
		Name = "herName",
		Email = new Email("herName@someMailProvider.com"),
		PhoneNumber = new PhoneNumber("+91 0987654321")
	};
}