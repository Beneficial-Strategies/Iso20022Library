// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV06 : IMandateInitiationRequestV06
{
    IGroupHeader80 IMandateInitiationRequestV06.GroupHeader => GroupHeader;
    IMandate13 IMandateInitiationRequestV06.Mandate => Mandate;
    ISupplementaryData1? IMandateInitiationRequestV06.SupplementaryData => SupplementaryData;
}
