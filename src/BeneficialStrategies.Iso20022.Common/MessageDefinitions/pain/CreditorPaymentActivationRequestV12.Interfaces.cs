// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV12 : ICreditorPaymentActivationRequestV12
{
    IGroupHeader112 ICreditorPaymentActivationRequestV12.GroupHeader => GroupHeader;
    IEnumerable<IPaymentInstruction48> ICreditorPaymentActivationRequestV12.PaymentInformation => PaymentInformation;
    IEnumerable<ISupplementaryData1> ICreditorPaymentActivationRequestV12.SupplementaryData => SupplementaryData;
}
