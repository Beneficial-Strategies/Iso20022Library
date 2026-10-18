// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFICustomerDirectDebitV02 : IFIToFICustomerDirectDebitV02
{
    IGroupHeader34 IFIToFICustomerDirectDebitV02.GroupHeader => GroupHeader;
    IDirectDebitTransactionInformation10 IFIToFICustomerDirectDebitV02.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
