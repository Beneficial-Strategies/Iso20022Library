// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransactionInformation25 : IPaymentTransactionInformation25
{
    IEnumerable<IStatusReasonInformation8> IPaymentTransactionInformation25.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<IChargesInformation5> IPaymentTransactionInformation25.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference13? IPaymentTransactionInformation25.OriginalTransactionReference => OriginalTransactionReference;
}
