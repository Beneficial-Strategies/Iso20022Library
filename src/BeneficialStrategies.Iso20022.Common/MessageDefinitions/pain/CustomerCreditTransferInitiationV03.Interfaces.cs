// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV03 : ICustomerCreditTransferInitiationV03
{
    IGroupHeader32 ICustomerCreditTransferInitiationV03.GroupHeader => GroupHeader;
    IPaymentInstructionInformation3 ICustomerCreditTransferInitiationV03.PaymentInformation => PaymentInformation;
}
