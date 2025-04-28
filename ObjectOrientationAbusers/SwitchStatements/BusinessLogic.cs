//Somewhere in the code
//Eg. Process a credit card payment
PaymentProcessor processor = new PaymentProcessor(new CreditCardStrategy());
processor.ProcessPayment(100.0);

//Eg. Process a PayPal payment
PaymentProcessor processor = new PaymentProcessor(new PayPalStrategy());
processor.ProcessPayment(50.0);