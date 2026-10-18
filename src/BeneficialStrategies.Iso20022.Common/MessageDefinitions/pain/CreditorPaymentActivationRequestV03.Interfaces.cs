// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV03 : ICreditorPaymentActivationRequestV03
{
    IGroupHeader45 ICreditorPaymentActivationRequestV03.GroupHeader => GroupHeader;
    IPaymentInstruction11 ICreditorPaymentActivationRequestV03.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV03.SupplementaryData => SupplementaryData;
}
