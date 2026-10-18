// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCopy2 : IMandateCopy2
{
    IOriginalMessageInformation1? IMandateCopy2.OriginalMessageInformation => OriginalMessageInformation;
    IOriginalMandate6Choice IMandateCopy2.OriginalMandate => OriginalMandate;
    IMandateStatus1Choice? IMandateCopy2.MandateStatus => MandateStatus;
    IEnumerable<ISupplementaryData1> IMandateCopy2.SupplementaryData => SupplementaryData;
}
