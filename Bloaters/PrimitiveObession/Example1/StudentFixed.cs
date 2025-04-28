class Student
{
	var user = new User
	{
		Name = "hisName",
		Email = new Email("hisName@someMailProvider.com"),
		PhoneNumber = new PhoneNumber("+91 1234567890")
	};
}