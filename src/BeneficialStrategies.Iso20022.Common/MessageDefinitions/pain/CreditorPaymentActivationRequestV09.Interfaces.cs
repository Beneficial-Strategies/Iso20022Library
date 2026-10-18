// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV09 : ICreditorPaymentActivationRequestV09
{
    IGroupHeader78 ICreditorPaymentActivationRequestV09.GroupHeader => GroupHeader;
    IPaymentInstruction41 ICreditorPaymentActivationRequestV09.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV09.SupplementaryData => SupplementaryData;
}
