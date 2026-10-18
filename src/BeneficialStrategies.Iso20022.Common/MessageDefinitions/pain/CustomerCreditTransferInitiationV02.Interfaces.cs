// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV02 : ICustomerCreditTransferInitiationV02
{
    IGroupHeader1 ICustomerCreditTransferInitiationV02.GroupHeader => GroupHeader;
    IPaymentInstructionInformation1 ICustomerCreditTransferInitiationV02.PaymentInformation => PaymentInformation;
}
