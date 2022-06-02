namespace Question4 {
    public interface IPaymentProvider {
        void CreditPayment ();
        void DebitPayment ();
        void EftPayment ();
    }
}