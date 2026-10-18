// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record BranchAndFinancialInstitutionIdentification8 : IBranchAndFinancialInstitutionIdentification8
{
    IFinancialInstitutionIdentification23 IBranchAndFinancialInstitutionIdentification8.FinancialInstitutionIdentification => FinancialInstitutionIdentification;
    IBranchData5? IBranchAndFinancialInstitutionIdentification8.BranchIdentification => BranchIdentification;
}
