// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV05 : ICreditorPaymentActivationRequestV05
{
    IGroupHeader45 ICreditorPaymentActivationRequestV05.GroupHeader => GroupHeader;
    IPaymentInstruction19 ICreditorPaymentActivationRequestV05.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV05.SupplementaryData => SupplementaryData;
}
