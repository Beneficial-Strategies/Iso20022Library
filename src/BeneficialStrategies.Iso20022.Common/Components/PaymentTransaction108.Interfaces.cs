// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction108 : IPaymentTransaction108
{
    IEnumerable<IPaymentReversalReason9> IPaymentTransaction108.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference28? IPaymentTransaction108.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction108.SupplementaryData => SupplementaryData;
}
