// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV02 : IFinancialInstitutionCreditTransferV02
{
    IGroupHeader35 IFinancialInstitutionCreditTransferV02.GroupHeader => GroupHeader;
    ICreditTransferTransactionInformation13 IFinancialInstitutionCreditTransferV02.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
