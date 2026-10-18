// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCopy1 : IMandateCopy1
{
    IOriginalMessageInformation1? IMandateCopy1.OriginalMessageInformation => OriginalMessageInformation;
    IOriginalMandate4Choice IMandateCopy1.OriginalMandate => OriginalMandate;
    IMandateStatus1Choice? IMandateCopy1.MandateStatus => MandateStatus;
    IEnumerable<ISupplementaryData1> IMandateCopy1.SupplementaryData => SupplementaryData;
}
