// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV11 : IFIToFICustomerDirectDebitV11
{
    IGroupHeader125 IFIToFICustomerDirectDebitV11.GroupHeader => GroupHeader;
    IEnumerable<IDirectDebitTransactionInformation31> IFIToFICustomerDirectDebitV11.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerDirectDebitV11.SupplementaryData => SupplementaryData;
}
