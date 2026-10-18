// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransactionInformation34 : IPaymentTransactionInformation34
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransactionInformation34.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<IChargesInformation7> IPaymentTransactionInformation34.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference15? IPaymentTransactionInformation34.OriginalTransactionReference => OriginalTransactionReference;
}
