// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentReversalReason7 : IPaymentReversalReason7
{
    IPartyIdentification43? IPaymentReversalReason7.Originator => Originator;
    IReversalReason4Choice? IPaymentReversalReason7.Reason => Reason;
    IEnumerable<Max105Text> IPaymentReversalReason7.AdditionalInformation => AdditionalInformation;
}
