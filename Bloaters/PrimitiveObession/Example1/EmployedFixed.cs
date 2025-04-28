class Employed
{
	var user = new User
	{
		Name = "herName",
		Email = new Email("herName@someMailProvider.com"),
		PhoneNumber = new PhoneNumber("+91 0987654321")
	};
}