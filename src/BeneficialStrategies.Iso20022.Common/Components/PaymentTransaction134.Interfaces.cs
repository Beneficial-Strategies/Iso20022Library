// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction134 : IPaymentTransaction134
{
    IEnumerable<IPaymentReversalReason9> IPaymentTransaction134.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference35? IPaymentTransaction134.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction134.SupplementaryData => SupplementaryData;
}
