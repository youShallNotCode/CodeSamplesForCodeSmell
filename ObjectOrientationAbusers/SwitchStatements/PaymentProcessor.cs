/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

class PaymentProcessor
{
    public void ProcessPayment(string PaymentMethod, double amount)
    {
        switch(PaymentMethod)
        {
            case "CREDIT_CARD":
                CreditCardService.Charge(amount);
                break;
            case "PAYPAL":
                PayPalService.SendPayment(amount);
                break;
            default:
                //throws Invalid Arg Exp
        }
    }
}