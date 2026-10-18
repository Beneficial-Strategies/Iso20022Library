// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV10 : IFIToFICustomerCreditTransferV10
{
    IGroupHeader96 IFIToFICustomerCreditTransferV10.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction50> IFIToFICustomerCreditTransferV10.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerCreditTransferV10.SupplementaryData => SupplementaryData;
}
