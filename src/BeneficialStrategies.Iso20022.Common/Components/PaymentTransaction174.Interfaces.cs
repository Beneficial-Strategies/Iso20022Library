// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction174 : IPaymentTransaction174
{
    IEnumerable<IPaymentReversalReason10> IPaymentTransaction174.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference47? IPaymentTransaction174.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction174.SupplementaryData => SupplementaryData;
}
