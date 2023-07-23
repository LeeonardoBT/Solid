namespace LSP.Payment
{
    interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
