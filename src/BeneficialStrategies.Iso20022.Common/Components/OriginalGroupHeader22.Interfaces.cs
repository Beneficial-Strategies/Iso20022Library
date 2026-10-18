// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupHeader22 : IOriginalGroupHeader22
{
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalGroupHeader22.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IStatusReasonInformation14> IOriginalGroupHeader22.StatusReasonInformation => StatusReasonInformation;
}
