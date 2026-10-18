// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV10 : IFIToFICustomerDirectDebitV10
{
    IGroupHeader98 IFIToFICustomerDirectDebitV10.GroupHeader => GroupHeader;
    IEnumerable<IDirectDebitTransactionInformation30> IFIToFICustomerDirectDebitV10.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerDirectDebitV10.SupplementaryData => SupplementaryData;
}
