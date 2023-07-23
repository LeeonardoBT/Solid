using System;

namespace LSP.Payment
{
    abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
        }

        public virtual void Validate()
        {
            // validação    
        }
    }
}
