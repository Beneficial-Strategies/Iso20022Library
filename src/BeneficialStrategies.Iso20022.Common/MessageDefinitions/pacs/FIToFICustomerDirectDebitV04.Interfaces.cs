// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV04 : IFIToFICustomerDirectDebitV04
{
    IGroupHeader50 IFIToFICustomerDirectDebitV04.GroupHeader => GroupHeader;
    IDirectDebitTransactionInformation14 IFIToFICustomerDirectDebitV04.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    ISupplementaryData1? IFIToFICustomerDirectDebitV04.SupplementaryData => SupplementaryData;
}
