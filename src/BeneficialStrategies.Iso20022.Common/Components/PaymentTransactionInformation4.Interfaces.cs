// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransactionInformation4 : IPaymentTransactionInformation4
{
    IEnumerable<IReversalReasonInformation1> IPaymentTransactionInformation4.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference1? IPaymentTransactionInformation4.OriginalTransactionReference => OriginalTransactionReference;
}
