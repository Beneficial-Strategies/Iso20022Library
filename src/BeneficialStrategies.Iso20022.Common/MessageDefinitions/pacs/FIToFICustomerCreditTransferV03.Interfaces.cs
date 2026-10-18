// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV03 : IFIToFICustomerCreditTransferV03
{
    IGroupHeader49 IFIToFICustomerCreditTransferV03.GroupHeader => GroupHeader;
    ICreditTransferTransaction2 IFIToFICustomerCreditTransferV03.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFIToFICustomerCreditTransferV03.SupplementaryData => SupplementaryData;
}
