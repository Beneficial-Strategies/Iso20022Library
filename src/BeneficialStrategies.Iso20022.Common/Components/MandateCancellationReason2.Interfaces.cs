// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellationReason2 : IMandateCancellationReason2
{
    IEnumerable<IsoMax105Text> IMandateCancellationReason2.AdditionalInformation => AdditionalInformation;
    IPartyIdentification272? IMandateCancellationReason2.Originator => Originator;
    IMandateReason1Choice IMandateCancellationReason2.Reason => Reason;
}
