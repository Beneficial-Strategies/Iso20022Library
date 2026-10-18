// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV07 : ICreditorPaymentActivationRequestV07
{
    IGroupHeader78 ICreditorPaymentActivationRequestV07.GroupHeader => GroupHeader;
    IPaymentInstruction31 ICreditorPaymentActivationRequestV07.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV07.SupplementaryData => SupplementaryData;
}
