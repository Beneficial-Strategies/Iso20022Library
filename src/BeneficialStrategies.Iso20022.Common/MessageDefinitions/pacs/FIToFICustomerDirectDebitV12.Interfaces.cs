// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV12 : IFIToFICustomerDirectDebitV12
{
    IGroupHeader125 IFIToFICustomerDirectDebitV12.GroupHeader => GroupHeader;
    IEnumerable<IDirectDebitTransactionInformation35> IFIToFICustomerDirectDebitV12.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerDirectDebitV12.SupplementaryData => SupplementaryData;
}
