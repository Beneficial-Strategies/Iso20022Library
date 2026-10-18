// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction57 : IPaymentTransaction57
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction57.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction57.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference20? IPaymentTransaction57.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction57.SupplementaryData => SupplementaryData;
}
