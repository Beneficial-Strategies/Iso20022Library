// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction33 : IOriginalPaymentInstruction33
{
    IEnumerable<IPaymentReversalReason9> IOriginalPaymentInstruction33.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction108> IOriginalPaymentInstruction33.TransactionInformation => TransactionInformation;
}
