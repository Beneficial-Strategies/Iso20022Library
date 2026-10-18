// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation3 : IMandateCancellation3
{
    IOriginalMessageInformation1? IMandateCancellation3.OriginalMessageInformation => OriginalMessageInformation;
    IPaymentCancellationReason1 IMandateCancellation3.CancellationReason => CancellationReason;
    IOriginalMandate2Choice IMandateCancellation3.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateCancellation3.SupplementaryData => SupplementaryData;
}
