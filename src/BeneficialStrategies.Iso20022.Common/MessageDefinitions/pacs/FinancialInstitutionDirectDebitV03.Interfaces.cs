// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionDirectDebitV03 : IFinancialInstitutionDirectDebitV03
{
    IGroupHeader92 IFinancialInstitutionDirectDebitV03.GroupHeader => GroupHeader;
    ICreditTransferTransaction38 IFinancialInstitutionDirectDebitV03.CreditInstruction => CreditInstruction;
    ISupplementaryData1? IFinancialInstitutionDirectDebitV03.SupplementaryData => SupplementaryData;
}
