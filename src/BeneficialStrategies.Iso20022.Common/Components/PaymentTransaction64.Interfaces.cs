// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction64 : IPaymentTransaction64
{
    IEnumerable<IPaymentReversalReason7> IPaymentTransaction64.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference22? IPaymentTransaction64.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction64.SupplementaryData => SupplementaryData;
}
