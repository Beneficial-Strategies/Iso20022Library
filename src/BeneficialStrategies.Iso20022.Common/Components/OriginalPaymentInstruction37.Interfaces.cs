// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction37 : IOriginalPaymentInstruction37
{
    IEnumerable<IPaymentReversalReason9> IOriginalPaymentInstruction37.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction125> IOriginalPaymentInstruction37.TransactionInformation => TransactionInformation;
}
