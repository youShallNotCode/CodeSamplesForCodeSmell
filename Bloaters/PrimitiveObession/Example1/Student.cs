/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class Student
{
	var user = new User();
	user.Name = "hisName";
	user.Email = "hisName@someMailProvider.com"
	user.PhoneNumber = "+91 1234567890"

	bool isValidEmail(user.Email)
	{
		//validation logic to checkEmail
	}

	bool isValidPhoneNumber(user.PhoneNumber)
	{
		//validation to check if this is a valid phone number
	}
}