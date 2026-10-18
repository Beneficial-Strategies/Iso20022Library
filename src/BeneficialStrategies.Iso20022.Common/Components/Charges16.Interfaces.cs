// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Charges16 : ICharges16
{
    IBranchAndFinancialInstitutionIdentification8 ICharges16.Agent => Agent;
    IChargeType3Choice? ICharges16.Type => Type;
}
