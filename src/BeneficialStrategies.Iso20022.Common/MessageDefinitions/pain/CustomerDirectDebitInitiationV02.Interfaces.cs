// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV02 : ICustomerDirectDebitInitiationV02
{
    IGroupHeader39 ICustomerDirectDebitInitiationV02.GroupHeader => GroupHeader;
    IPaymentInstructionInformation4 ICustomerDirectDebitInitiationV02.PaymentInformation => PaymentInformation;
}
