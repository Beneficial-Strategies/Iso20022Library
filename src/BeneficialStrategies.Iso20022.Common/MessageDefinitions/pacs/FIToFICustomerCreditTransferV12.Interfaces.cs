// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV12 : IFIToFICustomerCreditTransferV12
{
    IGroupHeader113 IFIToFICustomerCreditTransferV12.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction64> IFIToFICustomerCreditTransferV12.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerCreditTransferV12.SupplementaryData => SupplementaryData;
}
