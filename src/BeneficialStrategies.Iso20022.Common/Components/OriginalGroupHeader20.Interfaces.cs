// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupHeader20 : IOriginalGroupHeader20
{
    IEnumerable<IPaymentReversalReason10> IOriginalGroupHeader20.ReversalReasonInformation => ReversalReasonInformation;
}
