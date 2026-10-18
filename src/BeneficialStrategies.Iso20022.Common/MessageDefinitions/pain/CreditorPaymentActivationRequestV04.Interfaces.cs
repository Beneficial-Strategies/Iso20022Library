// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV04 : ICreditorPaymentActivationRequestV04
{
    IGroupHeader45 ICreditorPaymentActivationRequestV04.GroupHeader => GroupHeader;
    IPaymentInstruction17 ICreditorPaymentActivationRequestV04.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV04.SupplementaryData => SupplementaryData;
}
