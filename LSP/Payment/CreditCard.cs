using System;

namespace LSP.Payment
{
    class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando limite...");
            Console.WriteLine("Limite OK!");
        }
    }
}
