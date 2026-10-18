// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateCopy4 : IMandateCopy4
{
    IMandateStatus1Choice? IMandateCopy4.MandateStatus => MandateStatus;
    IOriginalMandate10Choice IMandateCopy4.OriginalMandate => OriginalMandate;
    IOriginalMessageInformation1? IMandateCopy4.OriginalMessageInformation => OriginalMessageInformation;
    IEnumerable<ISupplementaryData1> IMandateCopy4.SupplementaryData => SupplementaryData;
}
