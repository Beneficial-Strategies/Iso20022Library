// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV01 : IMandateInitiationRequestV01
{
    IGroupHeader31 IMandateInitiationRequestV01.GroupHeader => GroupHeader;
    IMandateInformation2 IMandateInitiationRequestV01.Mandate => Mandate;
}
