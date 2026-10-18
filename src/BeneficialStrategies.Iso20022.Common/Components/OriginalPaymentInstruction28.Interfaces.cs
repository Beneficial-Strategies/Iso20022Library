// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction28 : IOriginalPaymentInstruction28
{
    IEnumerable<IPaymentReversalReason8> IOriginalPaymentInstruction28.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction93> IOriginalPaymentInstruction28.TransactionInformation => TransactionInformation;
}
