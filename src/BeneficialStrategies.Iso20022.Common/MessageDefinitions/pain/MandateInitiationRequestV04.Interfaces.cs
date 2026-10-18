// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV04 : IMandateInitiationRequestV04
{
    IGroupHeader47 IMandateInitiationRequestV04.GroupHeader => GroupHeader;
    IMandate7 IMandateInitiationRequestV04.Mandate => Mandate;
    ISupplementaryData1? IMandateInitiationRequestV04.SupplementaryData => SupplementaryData;
}
