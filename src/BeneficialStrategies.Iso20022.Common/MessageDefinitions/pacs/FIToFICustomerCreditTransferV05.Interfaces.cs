// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV05 : IFIToFICustomerCreditTransferV05
{
    IGroupHeader49 IFIToFICustomerCreditTransferV05.GroupHeader => GroupHeader;
    ICreditTransferTransaction19 IFIToFICustomerCreditTransferV05.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFIToFICustomerCreditTransferV05.SupplementaryData => SupplementaryData;
}
