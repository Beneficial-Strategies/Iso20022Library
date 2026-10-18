// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionDirectDebitV04 : IFinancialInstitutionDirectDebitV04
{
    IGroupHeader92 IFinancialInstitutionDirectDebitV04.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction47> IFinancialInstitutionDirectDebitV04.CreditInstruction => CreditInstruction;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionDirectDebitV04.SupplementaryData => SupplementaryData;
}
