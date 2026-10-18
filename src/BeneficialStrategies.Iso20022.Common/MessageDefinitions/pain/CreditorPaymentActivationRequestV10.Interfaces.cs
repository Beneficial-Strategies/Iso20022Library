// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV10 : ICreditorPaymentActivationRequestV10
{
    IGroupHeader105 ICreditorPaymentActivationRequestV10.GroupHeader => GroupHeader;
    IPaymentInstruction42 ICreditorPaymentActivationRequestV10.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV10.SupplementaryData => SupplementaryData;
}
