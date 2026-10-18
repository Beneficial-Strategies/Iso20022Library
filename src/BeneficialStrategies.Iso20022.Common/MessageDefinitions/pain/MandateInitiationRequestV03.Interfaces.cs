// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV03 : IMandateInitiationRequestV03
{
    IGroupHeader47 IMandateInitiationRequestV03.GroupHeader => GroupHeader;
    IMandate4 IMandateInitiationRequestV03.Mandate => Mandate;
    ISupplementaryData1? IMandateInitiationRequestV03.SupplementaryData => SupplementaryData;
}
