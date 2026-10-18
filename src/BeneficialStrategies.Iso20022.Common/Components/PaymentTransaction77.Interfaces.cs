// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction77 : IPaymentTransaction77
{
    IEnumerable<IPaymentReversalReason7> IPaymentTransaction77.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference24? IPaymentTransaction77.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction77.SupplementaryData => SupplementaryData;
}
