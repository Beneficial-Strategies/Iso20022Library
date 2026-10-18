// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateSuspensionRequestV04 : IMandateSuspensionRequestV04
{
    IGroupHeader110 IMandateSuspensionRequestV04.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IMandateSuspensionRequestV04.SupplementaryData => SupplementaryData;
    IEnumerable<IMandateSuspension4> IMandateSuspensionRequestV04.UnderlyingSuspensionDetails => UnderlyingSuspensionDetails;
}
