// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction156 : IPaymentTransaction156
{
    IOriginalTransactionReference42? IPaymentTransaction156.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<IPaymentReversalReason10> IPaymentTransaction156.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<ISupplementaryData1> IPaymentTransaction156.SupplementaryData => SupplementaryData;
}
