// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation6 : IMandateCancellation6
{
    IOriginalMessageInformation1? IMandateCancellation6.OriginalMessageInformation => OriginalMessageInformation;
    IMandateCancellationReason1 IMandateCancellation6.CancellationReason => CancellationReason;
    IOriginalMandate6Choice IMandateCancellation6.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateCancellation6.SupplementaryData => SupplementaryData;
}
