// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV08 : ICreditorPaymentActivationRequestV08
{
    IGroupHeader78 ICreditorPaymentActivationRequestV08.GroupHeader => GroupHeader;
    IPaymentInstruction35 ICreditorPaymentActivationRequestV08.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV08.SupplementaryData => SupplementaryData;
}
