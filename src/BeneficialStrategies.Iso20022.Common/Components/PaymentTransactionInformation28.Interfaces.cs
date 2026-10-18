// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransactionInformation28 : IPaymentTransactionInformation28
{
    IEnumerable<IReversalReasonInformation6> IPaymentTransactionInformation28.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference13? IPaymentTransactionInformation28.OriginalTransactionReference => OriginalTransactionReference;
}
