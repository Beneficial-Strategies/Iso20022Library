// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestV02 : ICreditorPaymentActivationRequestV02
{
    IGroupHeader45 ICreditorPaymentActivationRequestV02.GroupHeader => GroupHeader;
    IPaymentInstruction8 ICreditorPaymentActivationRequestV02.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICreditorPaymentActivationRequestV02.SupplementaryData => SupplementaryData;
}
