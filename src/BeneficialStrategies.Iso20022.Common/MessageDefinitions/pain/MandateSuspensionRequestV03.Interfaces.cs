// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateSuspensionRequestV03 : IMandateSuspensionRequestV03
{
    IGroupHeader80 IMandateSuspensionRequestV03.GroupHeader => GroupHeader;
    IMandateSuspension3 IMandateSuspensionRequestV03.UnderlyingSuspensionDetails => UnderlyingSuspensionDetails;
    ISupplementaryData1? IMandateSuspensionRequestV03.SupplementaryData => SupplementaryData;
}
