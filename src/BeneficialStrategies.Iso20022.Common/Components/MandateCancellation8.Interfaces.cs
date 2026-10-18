// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation8 : IMandateCancellation8
{
    IMandateCancellationReason2 IMandateCancellation8.CancellationReason => CancellationReason;
    IOriginalMandate10Choice IMandateCancellation8.OriginalMandate => OriginalMandate;
    IOriginalMessageInformation1? IMandateCancellation8.OriginalMessageInformation => OriginalMessageInformation;
    IEnumerable<ISupplementaryData1> IMandateCancellation8.SupplementaryData => SupplementaryData;
}
