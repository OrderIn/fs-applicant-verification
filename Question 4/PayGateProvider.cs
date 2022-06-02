using System;

namespace Question4 {
    public class PayGateProvider : IPaymentProvider {
        public void CreditPayment () {
            Console.WriteLine ("Successfully processed credit payment. #001");
        }

        public void DebitPayment () {
            Console.WriteLine ("Successfully processed debit payment. #002");
        }

        public void EftPayment () {
            Console.WriteLine ("Successfully processed EFT transfer. #004");
        }
    }
}