// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation2 : IMandateCancellation2
{
    IOriginalMessageInformation1? IMandateCancellation2.OriginalMessageInformation => OriginalMessageInformation;
    IPaymentCancellationReason1 IMandateCancellation2.CancellationReason => CancellationReason;
    IOriginalMandate2Choice IMandateCancellation2.OriginalMandate => OriginalMandate;
}
