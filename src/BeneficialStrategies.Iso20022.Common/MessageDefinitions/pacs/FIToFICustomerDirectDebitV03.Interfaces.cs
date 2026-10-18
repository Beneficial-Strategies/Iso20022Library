// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV03 : IFIToFICustomerDirectDebitV03
{
    IGroupHeader50 IFIToFICustomerDirectDebitV03.GroupHeader => GroupHeader;
    IEnumerable<IDirectDebitTransactionInformation12> IFIToFICustomerDirectDebitV03.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFICustomerDirectDebitV03.SupplementaryData => SupplementaryData;
}
