// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV01 : IFIToFICustomerDirectDebitV01
{
    IGroupHeader3 IFIToFICustomerDirectDebitV01.GroupHeader => GroupHeader;
    IEnumerable<IDirectDebitTransactionInformation2> IFIToFICustomerDirectDebitV01.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
