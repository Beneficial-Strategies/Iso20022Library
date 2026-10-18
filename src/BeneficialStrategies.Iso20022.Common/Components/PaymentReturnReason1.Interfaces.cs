// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentReturnReason1 : IPaymentReturnReason1
{
    IPartyIdentification43? IPaymentReturnReason1.Originator => Originator;
    IReturnReason5Choice? IPaymentReturnReason1.Reason => Reason;
    IEnumerable<IsoMax105Text> IPaymentReturnReason1.AdditionalInformation => AdditionalInformation;
}
