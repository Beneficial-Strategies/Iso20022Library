// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction7 : IOriginalPaymentInstruction7
{
    IEnumerable<IPaymentReversalReason7> IOriginalPaymentInstruction7.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction42> IOriginalPaymentInstruction7.TransactionInformation => TransactionInformation;
}
