// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader92 : IGroupHeader92
{
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader92.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader92.InstructedAgent => InstructedAgent;
}
