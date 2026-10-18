// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party35Choice;

public partial record Agent : IAgent
{
    IFinancialInstitutionIdentification8 IAgent.FinancialInstitutionIdentification => FinancialInstitutionIdentification;
    IBranchData2? IAgent.BranchIdentification => BranchIdentification;
}
