// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction2 : IOriginalPaymentInstruction2
{
    IEnumerable<IPaymentReversalReason7> IOriginalPaymentInstruction2.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction35> IOriginalPaymentInstruction2.TransactionInformation => TransactionInformation;
}
