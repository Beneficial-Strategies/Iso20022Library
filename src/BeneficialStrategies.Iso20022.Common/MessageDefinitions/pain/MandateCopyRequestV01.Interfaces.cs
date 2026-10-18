// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCopyRequestV01 : IMandateCopyRequestV01
{
    IGroupHeader47 IMandateCopyRequestV01.GroupHeader => GroupHeader;
    IMandateCopy1 IMandateCopyRequestV01.UnderlyingCopyRequestDetails => UnderlyingCopyRequestDetails;
    ISupplementaryData1? IMandateCopyRequestV01.SupplementaryData => SupplementaryData;
}
