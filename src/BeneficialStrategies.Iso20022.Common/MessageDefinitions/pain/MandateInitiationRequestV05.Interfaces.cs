// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV05 : IMandateInitiationRequestV05
{
    IGroupHeader47 IMandateInitiationRequestV05.GroupHeader => GroupHeader;
    IMandate10 IMandateInitiationRequestV05.Mandate => Mandate;
    ISupplementaryData1? IMandateInitiationRequestV05.SupplementaryData => SupplementaryData;
}
