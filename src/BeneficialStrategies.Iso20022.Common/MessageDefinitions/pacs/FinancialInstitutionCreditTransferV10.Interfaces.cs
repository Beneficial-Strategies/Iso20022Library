// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV10 : IFinancialInstitutionCreditTransferV10
{
    IGroupHeader96 IFinancialInstitutionCreditTransferV10.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction56> IFinancialInstitutionCreditTransferV10.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFinancialInstitutionCreditTransferV10.SupplementaryData => SupplementaryData;
}
