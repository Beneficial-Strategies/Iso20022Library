// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record BranchAndFinancialInstitutionIdentification3 : IBranchAndFinancialInstitutionIdentification3
{
    IFinancialInstitutionIdentification5Choice IBranchAndFinancialInstitutionIdentification3.FinancialInstitutionIdentification => FinancialInstitutionIdentification;
    IBranchData? IBranchAndFinancialInstitutionIdentification3.BranchIdentification => BranchIdentification;
}
