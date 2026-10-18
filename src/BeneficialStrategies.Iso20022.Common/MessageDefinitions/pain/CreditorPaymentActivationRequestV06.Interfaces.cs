// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV06 : ICreditorPaymentActivationRequestV06
{
    IGroupHeader45 ICreditorPaymentActivationRequestV06.GroupHeader => GroupHeader;
    IPaymentInstruction23 ICreditorPaymentActivationRequestV06.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV06.SupplementaryData => SupplementaryData;
}
