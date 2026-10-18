// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader109 : IGroupHeader109
{
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader109.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader109.InstructedAgent => InstructedAgent;
}
