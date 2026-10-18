// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV07 : IMandateCancellationRequestV07
{
    IGroupHeader80 IMandateCancellationRequestV07.GroupHeader => GroupHeader;
    IMandateCancellation7 IMandateCancellationRequestV07.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
    ISupplementaryData1? IMandateCancellationRequestV07.SupplementaryData => SupplementaryData;
}
