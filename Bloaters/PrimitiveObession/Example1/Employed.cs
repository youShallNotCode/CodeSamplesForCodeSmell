/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class Employed
{
	var user = new User();
	user.Name = "herName";
	user.Email = "herName@someMailProvider.com"
	user.PhoneNumber = "+91 0987654321"

	bool isValidEmail(user.Email)
	{
		//almost same validation logic as the other
	}

	bool isValidPhoneNumber(user.PhoneNumber)
	{
		//almost same validation logic as the other
	}
}