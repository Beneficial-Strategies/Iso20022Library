// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCancellation1 : IMandateCancellation1
{
    IOriginalMessageInformation1? IMandateCancellation1.OriginalMessageInformation => OriginalMessageInformation;
    ICancellationReasonInformation2 IMandateCancellation1.CancellationReason => CancellationReason;
    IOriginalMandate1Choice IMandateCancellation1.OriginalMandate => OriginalMandate;
}
