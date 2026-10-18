// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateSuspensionRequestV02 : IMandateSuspensionRequestV02
{
    IGroupHeader80 IMandateSuspensionRequestV02.GroupHeader => GroupHeader;
    IMandateSuspension2 IMandateSuspensionRequestV02.UnderlyingSuspensionDetails => UnderlyingSuspensionDetails;
    ISupplementaryData1? IMandateSuspensionRequestV02.SupplementaryData => SupplementaryData;
}
