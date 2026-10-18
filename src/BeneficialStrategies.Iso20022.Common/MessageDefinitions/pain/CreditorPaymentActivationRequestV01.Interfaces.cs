// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV01 : ICreditorPaymentActivationRequestV01
{
    IGroupHeader45 ICreditorPaymentActivationRequestV01.GroupHeader => GroupHeader;
    IPaymentInstruction5 ICreditorPaymentActivationRequestV01.PaymentInformation => PaymentInformation;
}
