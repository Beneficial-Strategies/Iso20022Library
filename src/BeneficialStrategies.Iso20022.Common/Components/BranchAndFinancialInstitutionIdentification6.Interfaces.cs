// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record BranchAndFinancialInstitutionIdentification6 : IBranchAndFinancialInstitutionIdentification6
{
    IFinancialInstitutionIdentification18 IBranchAndFinancialInstitutionIdentification6.FinancialInstitutionIdentification => FinancialInstitutionIdentification;
    IBranchData3? IBranchAndFinancialInstitutionIdentification6.BranchIdentification => BranchIdentification;
}
