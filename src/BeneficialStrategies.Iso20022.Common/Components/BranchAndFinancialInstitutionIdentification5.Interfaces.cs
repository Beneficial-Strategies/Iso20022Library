// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record BranchAndFinancialInstitutionIdentification5 : IBranchAndFinancialInstitutionIdentification5
{
    IFinancialInstitutionIdentification8 IBranchAndFinancialInstitutionIdentification5.FinancialInstitutionIdentification => FinancialInstitutionIdentification;
    IBranchData2? IBranchAndFinancialInstitutionIdentification5.BranchIdentification => BranchIdentification;
}
