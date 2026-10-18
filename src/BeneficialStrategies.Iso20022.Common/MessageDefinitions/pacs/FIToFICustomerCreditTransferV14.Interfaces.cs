// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV14 : IFIToFICustomerCreditTransferV14
{
    IEnumerable<ICreditTransferTransaction73> IFIToFICustomerCreditTransferV14.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IGroupHeader131 IFIToFICustomerCreditTransferV14.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IFIToFICustomerCreditTransferV14.SupplementaryData => SupplementaryData;
}
