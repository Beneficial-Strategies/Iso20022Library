// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV06 : IMandateCancellationRequestV06
{
    IGroupHeader80 IMandateCancellationRequestV06.GroupHeader => GroupHeader;
    IMandateCancellation6 IMandateCancellationRequestV06.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
    ISupplementaryData1? IMandateCancellationRequestV06.SupplementaryData => SupplementaryData;
}
