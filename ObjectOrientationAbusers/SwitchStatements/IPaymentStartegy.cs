/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

interface IPaymentStrategy
{
    void Process(double amount);
}

class CreditCardStrategy implements IPaymentStrategy
{
    public void Process(double amount)
    {
        CreditCardService.Charge(amount);
    }
}

class PayPalStrategy implements IPaymentStrategy
{
    public void Process(double amount)
    {
        PayPalService.SendPayment(amount);
    }
}

class CryptoStrategy implements IPaymentStrategy
{
    public void Process(double amount)
    {
        CryptoWallet.Transfer(amount);
    }
}