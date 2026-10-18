// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateSuspensionReason2 : IMandateSuspensionReason2
{
    IPartyIdentification135? IMandateSuspensionReason2.Originator => Originator;
    IMandateSuspensionReason1Choice IMandateSuspensionReason2.Reason => Reason;
    IEnumerable<IsoMax105Text> IMandateSuspensionReason2.AdditionalInformation => AdditionalInformation;
}
