// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentReversalReason9 : IPaymentReversalReason9
{
    IPartyIdentification135? IPaymentReversalReason9.Originator => Originator;
    IReversalReason4Choice? IPaymentReversalReason9.Reason => Reason;
    IEnumerable<IsoMax105Text> IPaymentReversalReason9.AdditionalInformation => AdditionalInformation;
}
