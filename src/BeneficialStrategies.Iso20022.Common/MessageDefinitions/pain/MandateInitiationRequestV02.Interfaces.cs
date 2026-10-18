// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV02 : IMandateInitiationRequestV02
{
    IGroupHeader47 IMandateInitiationRequestV02.GroupHeader => GroupHeader;
    IMandate2 IMandateInitiationRequestV02.Mandate => Mandate;
    ISupplementaryData1? IMandateInitiationRequestV02.SupplementaryData => SupplementaryData;
}
