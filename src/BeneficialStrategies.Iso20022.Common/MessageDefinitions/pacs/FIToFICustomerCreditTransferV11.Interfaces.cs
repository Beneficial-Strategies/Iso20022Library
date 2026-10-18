// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV11 : IFIToFICustomerCreditTransferV11
{
    IGroupHeader96 IFIToFICustomerCreditTransferV11.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction58> IFIToFICustomerCreditTransferV11.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerCreditTransferV11.SupplementaryData => SupplementaryData;
}
