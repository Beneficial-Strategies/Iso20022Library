// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalGroupInformation1 : IOriginalGroupInformation1
{
    IEnumerable<IStatusReasonInformation1> IOriginalGroupInformation1.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus1> IOriginalGroupInformation1.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
}
