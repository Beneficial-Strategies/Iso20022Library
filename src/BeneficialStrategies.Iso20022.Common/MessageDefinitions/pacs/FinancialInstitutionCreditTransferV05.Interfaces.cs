// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV05 : IFinancialInstitutionCreditTransferV05
{
    IGroupHeader49 IFinancialInstitutionCreditTransferV05.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction17> IFinancialInstitutionCreditTransferV05.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionCreditTransferV05.SupplementaryData => SupplementaryData;
}
