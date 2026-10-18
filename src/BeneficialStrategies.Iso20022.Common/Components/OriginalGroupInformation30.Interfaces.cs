// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupInformation30 : IOriginalGroupInformation30
{
    IEnumerable<IStatusReasonInformation12> IOriginalGroupInformation30.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalGroupInformation30.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
}
