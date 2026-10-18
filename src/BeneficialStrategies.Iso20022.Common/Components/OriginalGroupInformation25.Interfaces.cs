// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupInformation25 : IOriginalGroupInformation25
{
    IEnumerable<IStatusReasonInformation9> IOriginalGroupInformation25.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalGroupInformation25.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
}
