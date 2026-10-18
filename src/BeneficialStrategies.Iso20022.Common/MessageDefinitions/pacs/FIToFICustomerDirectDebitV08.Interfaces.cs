// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV08 : IFIToFICustomerDirectDebitV08
{
    IGroupHeader94 IFIToFICustomerDirectDebitV08.GroupHeader => GroupHeader;
    IDirectDebitTransactionInformation24 IFIToFICustomerDirectDebitV08.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    ISupplementaryData1? IFIToFICustomerDirectDebitV08.SupplementaryData => SupplementaryData;
}
