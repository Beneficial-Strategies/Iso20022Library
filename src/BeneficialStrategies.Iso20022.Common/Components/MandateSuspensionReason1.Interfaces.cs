// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateSuspensionReason1 : IMandateSuspensionReason1
{
    IPartyIdentification43? IMandateSuspensionReason1.Originator => Originator;
    IMandateSuspensionReason1Choice IMandateSuspensionReason1.Reason => Reason;
    IEnumerable<IsoMax105Text> IMandateSuspensionReason1.AdditionalInformation => AdditionalInformation;
}
