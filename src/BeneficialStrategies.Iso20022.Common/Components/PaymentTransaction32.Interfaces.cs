// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction32 : IPaymentTransaction32
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction32.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction32.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference16? IPaymentTransaction32.OriginalTransactionReference => OriginalTransactionReference;
}
