// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction41 : IPaymentTransaction41
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction41.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction41.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference17? IPaymentTransaction41.OriginalTransactionReference => OriginalTransactionReference;
}
