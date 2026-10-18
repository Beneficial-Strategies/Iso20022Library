// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentReturnReason6 : IPaymentReturnReason6
{
    IPartyIdentification135? IPaymentReturnReason6.Originator => Originator;
    IReturnReason5Choice? IPaymentReturnReason6.Reason => Reason;
    IEnumerable<IsoMax105Text> IPaymentReturnReason6.AdditionalInformation => AdditionalInformation;
}
