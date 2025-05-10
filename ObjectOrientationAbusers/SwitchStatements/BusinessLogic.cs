/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

//Somewhere in the code
//Eg. Process a credit card payment
PaymentProcessor processor = new PaymentProcessor(new CreditCardStrategy());
processor.ProcessPayment(100.0);

//Eg. Process a PayPal payment
PaymentProcessor processor = new PaymentProcessor(new PayPalStrategy());
processor.ProcessPayment(50.0);