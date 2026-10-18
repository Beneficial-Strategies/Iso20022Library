// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction125 : IPaymentTransaction125
{
    IEnumerable<IPaymentReversalReason9> IPaymentTransaction125.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference31? IPaymentTransaction125.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction125.SupplementaryData => SupplementaryData;
}
