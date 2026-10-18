// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCopyRequestV02 : IMandateCopyRequestV02
{
    IGroupHeader80 IMandateCopyRequestV02.GroupHeader => GroupHeader;
    IMandateCopy2 IMandateCopyRequestV02.UnderlyingCopyRequestDetails => UnderlyingCopyRequestDetails;
    ISupplementaryData1? IMandateCopyRequestV02.SupplementaryData => SupplementaryData;
}
