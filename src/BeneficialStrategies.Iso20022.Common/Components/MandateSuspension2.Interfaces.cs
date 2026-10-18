// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateSuspension2 : IMandateSuspension2
{
    IOriginalMessageInformation1? IMandateSuspension2.OriginalMessageInformation => OriginalMessageInformation;
    IMandateSuspensionReason2 IMandateSuspension2.SuspensionReason => SuspensionReason;
    IOriginalMandate6Choice IMandateSuspension2.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateSuspension2.SupplementaryData => SupplementaryData;
}
