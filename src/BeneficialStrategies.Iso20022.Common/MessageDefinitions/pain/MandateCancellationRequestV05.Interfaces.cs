// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV05 : IMandateCancellationRequestV05
{
    IGroupHeader47 IMandateCancellationRequestV05.GroupHeader => GroupHeader;
    IMandateCancellation5 IMandateCancellationRequestV05.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
    ISupplementaryData1? IMandateCancellationRequestV05.SupplementaryData => SupplementaryData;
}
