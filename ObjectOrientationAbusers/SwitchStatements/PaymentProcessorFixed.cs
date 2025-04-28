class PaymentProcessor
{
    private final IPaymentStrategy strategy;
    //Inject the strategy (DI)
    public PaymentProcessor(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ProcessPayment(double amount)
    {
        strategy.Process(amount); //Delegates to the choosen strategy
    }
}