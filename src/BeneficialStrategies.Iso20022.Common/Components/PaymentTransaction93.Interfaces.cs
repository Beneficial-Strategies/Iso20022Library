// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction93 : IPaymentTransaction93
{
    IEnumerable<IPaymentReversalReason8> IPaymentTransaction93.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference27? IPaymentTransaction93.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction93.SupplementaryData => SupplementaryData;
}
