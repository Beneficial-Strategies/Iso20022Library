// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerCreditTransferV02 : IFIToFICustomerCreditTransferV02
{
    IGroupHeader33 IFIToFICustomerCreditTransferV02.GroupHeader => GroupHeader;
    IEnumerable<ICreditTransferTransactionInformation11> IFIToFICustomerCreditTransferV02.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
