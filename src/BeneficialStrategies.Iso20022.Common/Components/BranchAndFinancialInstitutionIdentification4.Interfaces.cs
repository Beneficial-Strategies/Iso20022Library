// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record BranchAndFinancialInstitutionIdentification4 : IBranchAndFinancialInstitutionIdentification4
{
    IFinancialInstitutionIdentification7 IBranchAndFinancialInstitutionIdentification4.FinancialInstitutionIdentification => FinancialInstitutionIdentification;
    IBranchData2? IBranchAndFinancialInstitutionIdentification4.BranchIdentification => BranchIdentification;
}
