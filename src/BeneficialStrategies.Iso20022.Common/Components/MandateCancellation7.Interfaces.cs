// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation7 : IMandateCancellation7
{
    IOriginalMessageInformation1? IMandateCancellation7.OriginalMessageInformation => OriginalMessageInformation;
    IMandateCancellationReason1 IMandateCancellation7.CancellationReason => CancellationReason;
    IOriginalMandate9Choice IMandateCancellation7.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateCancellation7.SupplementaryData => SupplementaryData;
}
