// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV11 : ICreditorPaymentActivationRequestV11
{
    IGroupHeader112 ICreditorPaymentActivationRequestV11.GroupHeader => GroupHeader;
    IEnumerable<IPaymentInstruction46> ICreditorPaymentActivationRequestV11.PaymentInformation => PaymentInformation;
    IEnumerable<ISupplementaryData1> ICreditorPaymentActivationRequestV11.SupplementaryData => SupplementaryData;
}
