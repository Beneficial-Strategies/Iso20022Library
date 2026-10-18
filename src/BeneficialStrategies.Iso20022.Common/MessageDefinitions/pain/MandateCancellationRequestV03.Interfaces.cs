// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV03 : IMandateCancellationRequestV03
{
    IGroupHeader47 IMandateCancellationRequestV03.GroupHeader => GroupHeader;
    IMandateCancellation3 IMandateCancellationRequestV03.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
    ISupplementaryData1? IMandateCancellationRequestV03.SupplementaryData => SupplementaryData;
}
