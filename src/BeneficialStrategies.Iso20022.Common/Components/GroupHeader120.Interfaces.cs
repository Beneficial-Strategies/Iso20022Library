// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader120 : IGroupHeader120
{
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader120.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader120.InstructingAgent => InstructingAgent;
    IOriginalBusinessQuery1? IGroupHeader120.OriginalBusinessQuery => OriginalBusinessQuery;
}
