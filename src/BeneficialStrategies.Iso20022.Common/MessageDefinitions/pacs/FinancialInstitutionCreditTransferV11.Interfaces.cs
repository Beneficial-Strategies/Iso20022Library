// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV11 : IFinancialInstitutionCreditTransferV11
{
    IGroupHeader113 IFinancialInstitutionCreditTransferV11.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction62> IFinancialInstitutionCreditTransferV11.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionCreditTransferV11.SupplementaryData => SupplementaryData;
}
