// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV13 : IFIToFICustomerCreditTransferV13
{
    IEnumerable<ICreditTransferTransaction70> IFIToFICustomerCreditTransferV13.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IGroupHeader131 IFIToFICustomerCreditTransferV13.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IFIToFICustomerCreditTransferV13.SupplementaryData => SupplementaryData;
}
