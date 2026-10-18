// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionDirectDebitV06 : IFinancialInstitutionDirectDebitV06
{
    IGroupHeader119 IFinancialInstitutionDirectDebitV06.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction66> IFinancialInstitutionDirectDebitV06.CreditInstruction => CreditInstruction;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionDirectDebitV06.SupplementaryData => SupplementaryData;
}
