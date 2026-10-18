// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV13 : IFinancialInstitutionCreditTransferV13
{
    IGroupHeader131 IFinancialInstitutionCreditTransferV13.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction79> IFinancialInstitutionCreditTransferV13.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionCreditTransferV13.SupplementaryData => SupplementaryData;
}
