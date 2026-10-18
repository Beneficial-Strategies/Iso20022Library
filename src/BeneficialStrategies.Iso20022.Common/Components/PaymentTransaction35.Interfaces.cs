// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction35 : IPaymentTransaction35
{
    IEnumerable<IPaymentReversalReason7> IPaymentTransaction35.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference16? IPaymentTransaction35.OriginalTransactionReference => OriginalTransactionReference;
}
