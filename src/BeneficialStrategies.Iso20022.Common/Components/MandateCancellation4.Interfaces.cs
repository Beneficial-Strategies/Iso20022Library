// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation4 : IMandateCancellation4
{
    IOriginalMessageInformation1? IMandateCancellation4.OriginalMessageInformation => OriginalMessageInformation;
    IPaymentCancellationReason1 IMandateCancellation4.CancellationReason => CancellationReason;
    IOriginalMandate3Choice IMandateCancellation4.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateCancellation4.SupplementaryData => SupplementaryData;
}
