// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV12 : IFinancialInstitutionCreditTransferV12
{
    IEnumerable<ICreditTransferTransaction67> IFinancialInstitutionCreditTransferV12.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IGroupHeader131 IFinancialInstitutionCreditTransferV12.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionCreditTransferV12.SupplementaryData => SupplementaryData;
}
