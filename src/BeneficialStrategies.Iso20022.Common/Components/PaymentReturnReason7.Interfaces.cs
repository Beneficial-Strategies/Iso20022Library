// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentReturnReason7 : IPaymentReturnReason7
{
    IEnumerable<IsoMax105Text> IPaymentReturnReason7.AdditionalInformation => AdditionalInformation;
    IPartyIdentification272? IPaymentReturnReason7.Originator => Originator;
    IReturnReason5Choice? IPaymentReturnReason7.Reason => Reason;
}
