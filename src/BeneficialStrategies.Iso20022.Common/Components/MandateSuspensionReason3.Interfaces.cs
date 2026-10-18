// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateSuspensionReason3 : IMandateSuspensionReason3
{
    IEnumerable<IsoMax105Text> IMandateSuspensionReason3.AdditionalInformation => AdditionalInformation;
    IPartyIdentification272? IMandateSuspensionReason3.Originator => Originator;
    IMandateSuspensionReason1Choice IMandateSuspensionReason3.Reason => Reason;
}
