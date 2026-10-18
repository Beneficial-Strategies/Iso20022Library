// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV02 : IMandateCancellationRequestV02
{
    IGroupHeader47 IMandateCancellationRequestV02.GroupHeader => GroupHeader;
    IMandateCancellation2 IMandateCancellationRequestV02.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
    ISupplementaryData1? IMandateCancellationRequestV02.SupplementaryData => SupplementaryData;
}
