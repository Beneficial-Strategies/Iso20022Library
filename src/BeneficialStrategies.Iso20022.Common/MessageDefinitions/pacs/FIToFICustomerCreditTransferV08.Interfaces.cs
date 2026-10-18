// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV08 : IFIToFICustomerCreditTransferV08
{
    IGroupHeader93 IFIToFICustomerCreditTransferV08.GroupHeader => GroupHeader;
    ICreditTransferTransaction39 IFIToFICustomerCreditTransferV08.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    ISupplementaryData1? IFIToFICustomerCreditTransferV08.SupplementaryData => SupplementaryData;
}
