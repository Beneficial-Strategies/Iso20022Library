// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FinancialInstitutionCreditTransferV09 : IFinancialInstitutionCreditTransferV09
{
    IGroupHeader93 IFinancialInstitutionCreditTransferV09.GroupHeader => GroupHeader;
    ICreditTransferTransaction44 IFinancialInstitutionCreditTransferV09.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFinancialInstitutionCreditTransferV09.SupplementaryData => SupplementaryData;
}
