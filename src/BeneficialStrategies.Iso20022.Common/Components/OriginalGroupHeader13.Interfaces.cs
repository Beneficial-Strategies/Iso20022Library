// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupHeader13 : IOriginalGroupHeader13
{
    IEnumerable<IStatusReasonInformation11> IOriginalGroupHeader13.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalGroupHeader13.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
}
