// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateSuspension1 : IMandateSuspension1
{
    IOriginalMessageInformation1? IMandateSuspension1.OriginalMessageInformation => OriginalMessageInformation;
    IMandateSuspensionReason1 IMandateSuspension1.SuspensionReason => SuspensionReason;
    IOriginalMandate4Choice IMandateSuspension1.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateSuspension1.SupplementaryData => SupplementaryData;
}
