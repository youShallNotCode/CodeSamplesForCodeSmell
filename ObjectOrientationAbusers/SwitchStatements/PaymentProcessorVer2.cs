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
            case "CRYPTO":
                CryptoWallet.Transfer(amount);
                break;
            default:
                //throws Invalid Arg Exp
        }
    }
}