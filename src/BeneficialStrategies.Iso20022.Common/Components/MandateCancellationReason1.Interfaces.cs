// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellationReason1 : IMandateCancellationReason1
{
    IPartyIdentification135? IMandateCancellationReason1.Originator => Originator;
    IMandateReason1Choice IMandateCancellationReason1.Reason => Reason;
    IEnumerable<IsoMax105Text> IMandateCancellationReason1.AdditionalInformation => AdditionalInformation;
}
