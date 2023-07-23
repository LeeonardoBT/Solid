using LSP.Payment;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();

        }
    }
}
