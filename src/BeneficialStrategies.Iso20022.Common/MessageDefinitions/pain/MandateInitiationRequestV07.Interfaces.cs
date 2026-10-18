// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV07 : IMandateInitiationRequestV07
{
    IGroupHeader80 IMandateInitiationRequestV07.GroupHeader => GroupHeader;
    IMandate19 IMandateInitiationRequestV07.Mandate => Mandate;
    ISupplementaryData1? IMandateInitiationRequestV07.SupplementaryData => SupplementaryData;
}
