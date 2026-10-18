// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Charges12 : ICharges12
{
    IBranchAndFinancialInstitutionIdentification6 ICharges12.Agent => Agent;
    IChargeType3Choice? ICharges12.Type => Type;
}
