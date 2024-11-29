// See https://aka.ms/new-console-template for more information

//The Strategy Pattern is a behavioral design pattern that allows selecting an algorithm's behavior at runtime. It defines a family of algorithms, encapsulates each one, and makes them interchangeable.

//This example demonstrates a payment processing system where different payment methods (Credit Card, PayPal, Bank Transfer) can be used interchangeably at runtime.

using StrategyDesignPatternExample;

Console.WriteLine("Hello, World!");


PaymentContext paymentContext = new PaymentContext();

Console.WriteLine("Choose a payment method:");
Console.WriteLine("1. Credit Card");
Console.WriteLine("2. PayPal");
Console.WriteLine("3. Bank Transfer");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        paymentContext.SetPaymentStrategy(new CreditCardPayment());
        break;
    case "2":
        paymentContext.SetPaymentStrategy(new PayPalPayment());
        break;
    case "3":
        paymentContext.SetPaymentStrategy(new BankTransferPayment());
        break;
    default:
        Console.WriteLine("Invalid choice.");
        return;
}

Console.WriteLine("Enter the amount to pay:");
if (decimal.TryParse(Console.ReadLine(), out decimal amount))
{
    paymentContext.ProcessPayment(amount);
}
else
{
    Console.WriteLine("Invalid amount.");
}


