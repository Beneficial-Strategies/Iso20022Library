// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader101 : IGroupHeader101
{
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader101.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader101.InstructedAgent => InstructedAgent;
    IOriginalBusinessQuery1? IGroupHeader101.OriginalBusinessQuery => OriginalBusinessQuery;
}
