// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateInitiationRequestV08 : IMandateInitiationRequestV08
{
    IGroupHeader110 IMandateInitiationRequestV08.GroupHeader => GroupHeader;
    IEnumerable<IMandate23> IMandateInitiationRequestV08.Mandate => Mandate;
    IEnumerable<ISupplementaryData1> IMandateInitiationRequestV08.SupplementaryData => SupplementaryData;
}
