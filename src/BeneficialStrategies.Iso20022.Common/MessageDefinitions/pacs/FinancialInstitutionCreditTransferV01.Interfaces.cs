// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV01 : IFinancialInstitutionCreditTransferV01
{
    IGroupHeader4 IFinancialInstitutionCreditTransferV01.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransactionInformation3> IFinancialInstitutionCreditTransferV01.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
