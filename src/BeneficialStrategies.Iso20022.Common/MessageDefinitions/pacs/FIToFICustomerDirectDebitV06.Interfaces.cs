// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV06 : IFIToFICustomerDirectDebitV06
{
    IGroupHeader50 IFIToFICustomerDirectDebitV06.GroupHeader => GroupHeader;
    IEnumerable<IDirectDebitTransactionInformation20> IFIToFICustomerDirectDebitV06.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerDirectDebitV06.SupplementaryData => SupplementaryData;
}
