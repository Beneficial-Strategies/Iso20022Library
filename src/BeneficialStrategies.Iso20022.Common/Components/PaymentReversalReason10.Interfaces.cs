// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentReversalReason10 : IPaymentReversalReason10
{
    IPartyIdentification272? IPaymentReversalReason10.Originator => Originator;
    IReversalReason4Choice? IPaymentReversalReason10.Reason => Reason;
    IEnumerable<Max105Text> IPaymentReversalReason10.AdditionalInformation => AdditionalInformation;
}
