// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateSuspension3 : IMandateSuspension3
{
    IOriginalMessageInformation1? IMandateSuspension3.OriginalMessageInformation => OriginalMessageInformation;
    IMandateSuspensionReason2 IMandateSuspension3.SuspensionReason => SuspensionReason;
    IOriginalMandate9Choice IMandateSuspension3.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateSuspension3.SupplementaryData => SupplementaryData;
}
