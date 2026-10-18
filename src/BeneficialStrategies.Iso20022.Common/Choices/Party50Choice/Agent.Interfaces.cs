// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party50Choice;

public partial record Agent : IAgent
{
    IBranchAndFinancialInstitutionIdentification8 IAgent.Value => Value;
}
