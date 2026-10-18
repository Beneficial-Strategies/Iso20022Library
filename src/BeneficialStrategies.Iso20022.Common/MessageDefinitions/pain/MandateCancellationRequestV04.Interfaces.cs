// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV04 : IMandateCancellationRequestV04
{
    IGroupHeader47 IMandateCancellationRequestV04.GroupHeader => GroupHeader;
    IMandateCancellation4 IMandateCancellationRequestV04.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
    ISupplementaryData1? IMandateCancellationRequestV04.SupplementaryData => SupplementaryData;
}
