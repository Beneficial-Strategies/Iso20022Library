// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionDirectDebitV05 : IFinancialInstitutionDirectDebitV05
{
    IGroupHeader92 IFinancialInstitutionDirectDebitV05.GroupHeader => GroupHeader;
    ICreditTransferTransaction53 IFinancialInstitutionDirectDebitV05.CreditInstruction => CreditInstruction;
    ISupplementaryData1? IFinancialInstitutionDirectDebitV05.SupplementaryData => SupplementaryData;
}
