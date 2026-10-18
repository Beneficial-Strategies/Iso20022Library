// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateCancellationRequestV08 : IMandateCancellationRequestV08
{
    IGroupHeader110 IMandateCancellationRequestV08.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IMandateCancellationRequestV08.SupplementaryData => SupplementaryData;
    IEnumerable<IMandateCancellation8> IMandateCancellationRequestV08.UnderlyingCancellationDetails => UnderlyingCancellationDetails;
}
