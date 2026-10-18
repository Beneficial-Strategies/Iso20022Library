// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction56 : IPaymentTransaction56
{
    IEnumerable<IPaymentReversalReason7> IPaymentTransaction56.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference20? IPaymentTransaction56.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction56.SupplementaryData => SupplementaryData;
}
