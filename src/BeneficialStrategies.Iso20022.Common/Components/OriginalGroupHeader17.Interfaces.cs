// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupHeader17 : IOriginalGroupHeader17
{
    IEnumerable<IStatusReasonInformation12> IOriginalGroupHeader17.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalGroupHeader17.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
}
