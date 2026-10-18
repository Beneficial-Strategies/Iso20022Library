// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV09 : IFIToFICustomerCreditTransferV09
{
    IGroupHeader93 IFIToFICustomerCreditTransferV09.GroupHeader => GroupHeader;
    ICreditTransferTransaction43 IFIToFICustomerCreditTransferV09.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFIToFICustomerCreditTransferV09.SupplementaryData => SupplementaryData;
}
