// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupInformation28 : IOriginalGroupInformation28
{
    IEnumerable<IStatusReasonInformation9> IOriginalGroupInformation28.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalGroupInformation28.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
}
