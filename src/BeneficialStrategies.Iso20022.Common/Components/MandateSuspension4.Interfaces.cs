// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateSuspension4 : IMandateSuspension4
{
    IOriginalMandate10Choice IMandateSuspension4.OriginalMandate => OriginalMandate;
    IOriginalMessageInformation1? IMandateSuspension4.OriginalMessageInformation => OriginalMessageInformation;
    IEnumerable<ISupplementaryData1> IMandateSuspension4.SupplementaryData => SupplementaryData;
    IMandateSuspensionReason3 IMandateSuspension4.SuspensionReason => SuspensionReason;
}
