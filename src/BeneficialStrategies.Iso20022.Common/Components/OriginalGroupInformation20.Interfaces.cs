// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupInformation20 : IOriginalGroupInformation20
{
    IEnumerable<IStatusReasonInformation8> IOriginalGroupInformation20.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalGroupInformation20.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
}
