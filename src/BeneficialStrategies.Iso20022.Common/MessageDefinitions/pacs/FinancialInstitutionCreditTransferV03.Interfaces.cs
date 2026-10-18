// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV03 : IFinancialInstitutionCreditTransferV03
{
    IGroupHeader51 IFinancialInstitutionCreditTransferV03.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction4> IFinancialInstitutionCreditTransferV03.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionCreditTransferV03.SupplementaryData => SupplementaryData;
}
