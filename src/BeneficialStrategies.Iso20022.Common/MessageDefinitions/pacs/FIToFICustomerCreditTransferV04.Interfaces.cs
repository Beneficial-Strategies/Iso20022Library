// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV04 : IFIToFICustomerCreditTransferV04
{
    IGroupHeader49 IFIToFICustomerCreditTransferV04.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransaction7> IFIToFICustomerCreditTransferV04.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerCreditTransferV04.SupplementaryData => SupplementaryData;
}
