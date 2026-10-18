// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupInformation22 : IOriginalGroupInformation22
{
    IEnumerable<IReversalReasonInformation6> IOriginalGroupInformation22.ReversalReasonInformation => ReversalReasonInformation;
}
