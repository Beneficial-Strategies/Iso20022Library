// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV09 : IFIToFICustomerDirectDebitV09
{
    IGroupHeader98 IFIToFICustomerDirectDebitV09.GroupHeader => GroupHeader;
    IDirectDebitTransactionInformation29 IFIToFICustomerDirectDebitV09.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    ISupplementaryData1? IFIToFICustomerDirectDebitV09.SupplementaryData => SupplementaryData;
}
