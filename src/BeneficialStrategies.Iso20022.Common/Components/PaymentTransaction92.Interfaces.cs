// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction92 : IPaymentTransaction92
{
    IEnumerable<IStatusReasonInformation11> IPaymentTransaction92.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction92.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference27? IPaymentTransaction92.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction92.SupplementaryData => SupplementaryData;
}
