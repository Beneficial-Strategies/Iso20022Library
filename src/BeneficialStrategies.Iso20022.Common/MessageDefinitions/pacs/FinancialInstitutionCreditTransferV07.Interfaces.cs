// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV07 : IFinancialInstitutionCreditTransferV07
{
    IGroupHeader70 IFinancialInstitutionCreditTransferV07.GroupHeader => GroupHeader;
    ICreditTransferTransaction31 IFinancialInstitutionCreditTransferV07.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFinancialInstitutionCreditTransferV07.SupplementaryData => SupplementaryData;
}
