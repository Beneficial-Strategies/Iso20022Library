// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentReturnReason4 : IPaymentReturnReason4
{
    IPartyIdentification125? IPaymentReturnReason4.Originator => Originator;
    IReturnReason5Choice? IPaymentReturnReason4.Reason => Reason;
    IEnumerable<Max105Text> IPaymentReturnReason4.AdditionalInformation => AdditionalInformation;
}
