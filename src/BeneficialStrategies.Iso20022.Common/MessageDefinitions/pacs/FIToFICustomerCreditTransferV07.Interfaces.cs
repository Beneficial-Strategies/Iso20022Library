// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV07 : IFIToFICustomerCreditTransferV07
{
    IGroupHeader70 IFIToFICustomerCreditTransferV07.GroupHeader => GroupHeader;
    ICreditTransferTransaction30 IFIToFICustomerCreditTransferV07.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFIToFICustomerCreditTransferV07.SupplementaryData => SupplementaryData;
}
