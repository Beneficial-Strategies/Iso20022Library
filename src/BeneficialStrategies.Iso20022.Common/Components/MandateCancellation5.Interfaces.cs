// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation5 : IMandateCancellation5
{
    IOriginalMessageInformation1? IMandateCancellation5.OriginalMessageInformation => OriginalMessageInformation;
    IPaymentCancellationReason1 IMandateCancellation5.CancellationReason => CancellationReason;
    IOriginalMandate4Choice IMandateCancellation5.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateCancellation5.SupplementaryData => SupplementaryData;
}
