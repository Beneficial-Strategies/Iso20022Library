// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader119 : IGroupHeader119
{
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader119.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader119.InstructingAgent => InstructingAgent;
}
