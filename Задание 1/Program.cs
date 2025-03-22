using System;

abstract class PaymentMethod
{
    public abstract void Pay(decimal amount);
}

class CreditCard : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount} с кредитной карты.");
    }
}

class PayPal : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount} через PayPal.");
    }
}

class Cash : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount} наличными.");
    }
}

class Program
{
    static void Main()
    {
        PaymentMethod[] paymentMethods = new PaymentMethod[]
        {
            new CreditCard(),
            new PayPal(),
            new Cash()
        };

        decimal amountToPay = 100.50m;

        foreach (var method in paymentMethods)
        {
            method.Pay(amountToPay);
        }
    }
}