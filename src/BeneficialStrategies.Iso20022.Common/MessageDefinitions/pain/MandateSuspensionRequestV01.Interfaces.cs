// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateSuspensionRequestV01 : IMandateSuspensionRequestV01
{
    IGroupHeader47 IMandateSuspensionRequestV01.GroupHeader => GroupHeader;
    IMandateSuspension1 IMandateSuspensionRequestV01.UnderlyingSuspensionDetails => UnderlyingSuspensionDetails;
    ISupplementaryData1? IMandateSuspensionRequestV01.SupplementaryData => SupplementaryData;
}
