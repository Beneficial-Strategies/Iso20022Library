// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV06 : IFinancialInstitutionCreditTransferV06
{
    IGroupHeader70 IFinancialInstitutionCreditTransferV06.GroupHeader => GroupHeader;
    ICreditTransferTransaction23 IFinancialInstitutionCreditTransferV06.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFinancialInstitutionCreditTransferV06.SupplementaryData => SupplementaryData;
}
