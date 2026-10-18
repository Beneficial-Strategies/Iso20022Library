// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV01 : IMandateCancellationRequestV01
{
    IGroupHeader31 IMandateCancellationRequestV01.GroupHeader => GroupHeader;
    IMandateCancellation1 IMandateCancellationRequestV01.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
}
