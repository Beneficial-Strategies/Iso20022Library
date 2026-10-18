// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction53 : IOriginalPaymentInstruction53
{
    IEnumerable<IPaymentReversalReason10> IOriginalPaymentInstruction53.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction174> IOriginalPaymentInstruction53.TransactionInformation => TransactionInformation;
}
