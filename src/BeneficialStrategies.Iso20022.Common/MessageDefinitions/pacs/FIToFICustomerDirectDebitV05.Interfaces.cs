// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV05 : IFIToFICustomerDirectDebitV05
{
    IGroupHeader50 IFIToFICustomerDirectDebitV05.GroupHeader => GroupHeader;
    IDirectDebitTransactionInformation17 IFIToFICustomerDirectDebitV05.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    ISupplementaryData1? IFIToFICustomerDirectDebitV05.SupplementaryData => SupplementaryData;
}
