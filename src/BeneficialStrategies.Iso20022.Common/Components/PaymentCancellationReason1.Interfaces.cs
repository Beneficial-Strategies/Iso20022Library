// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentCancellationReason1 : IPaymentCancellationReason1
{
    IPartyIdentification43? IPaymentCancellationReason1.Originator => Originator;
    IMandateReason1Choice IPaymentCancellationReason1.Reason => Reason;
    IEnumerable<IsoMax105Text> IPaymentCancellationReason1.AdditionalInformation => AdditionalInformation;
}
