// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCopyRequestV04 : IMandateCopyRequestV04
{
    IGroupHeader110 IMandateCopyRequestV04.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IMandateCopyRequestV04.SupplementaryData => SupplementaryData;
    IEnumerable<IMandateCopy4> IMandateCopyRequestV04.UnderlyingCopyRequestDetails => UnderlyingCopyRequestDetails;
}
