using System;

interface ICreditPayment
{
    void ProcessPayment(decimal amount);
}

interface IDebitPayment
{
    void ProcessPayment(decimal amount);
}

class PaymentProcessor : ICreditPayment, IDebitPayment
{
    void ICreditPayment.ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Кредитный платеж на сумму: {amount}");
    }

    void IDebitPayment.ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Дебетовый платеж на сумму: {amount}");
    }
}

class Program
{
    static void Main()
    {
        PaymentProcessor paymentProcessor = new PaymentProcessor();

        ICreditPayment creditPayment = paymentProcessor;
        IDebitPayment debitPayment = paymentProcessor;

        creditPayment.ProcessPayment(150.75m);
        debitPayment.ProcessPayment(75.25m);
    }
}