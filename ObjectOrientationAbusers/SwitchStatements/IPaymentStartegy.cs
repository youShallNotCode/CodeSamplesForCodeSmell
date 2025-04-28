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