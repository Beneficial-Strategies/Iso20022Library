// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCopyRequestV03 : IMandateCopyRequestV03
{
    IGroupHeader80 IMandateCopyRequestV03.GroupHeader => GroupHeader;
    IMandateCopy3 IMandateCopyRequestV03.UnderlyingCopyRequestDetails => UnderlyingCopyRequestDetails;
    ISupplementaryData1? IMandateCopyRequestV03.SupplementaryData => SupplementaryData;
}
