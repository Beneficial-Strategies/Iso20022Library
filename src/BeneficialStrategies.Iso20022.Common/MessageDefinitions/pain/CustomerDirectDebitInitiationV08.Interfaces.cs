// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV08 : ICustomerDirectDebitInitiationV08
{
    IGroupHeader83 ICustomerDirectDebitInitiationV08.GroupHeader => GroupHeader;
    IPaymentInstruction29 ICustomerDirectDebitInitiationV08.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV08.SupplementaryData => SupplementaryData;
}
