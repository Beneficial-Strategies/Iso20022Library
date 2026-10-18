// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader63 : IGroupHeader63
{
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader63.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader63.InstructedAgent => InstructedAgent;
}
