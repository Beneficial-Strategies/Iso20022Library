// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV04 : IFinancialInstitutionCreditTransferV04
{
    IGroupHeader49 IFinancialInstitutionCreditTransferV04.GroupHeader => GroupHeader;
    ICreditTransferTransaction8 IFinancialInstitutionCreditTransferV04.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFinancialInstitutionCreditTransferV04.SupplementaryData => SupplementaryData;
}
