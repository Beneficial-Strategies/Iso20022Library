// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV01 : ICustomerDirectDebitInitiationV01
{
    IGroupHeader1 ICustomerDirectDebitInitiationV01.GroupHeader => GroupHeader;
    IPaymentInstructionInformation2 ICustomerDirectDebitInitiationV01.PaymentInformation => PaymentInformation;
}
