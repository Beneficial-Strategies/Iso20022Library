// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance3 : IMandateAcceptance3
{
    IOriginalMessageInformation1? IMandateAcceptance3.OriginalMessageInformation => OriginalMessageInformation;
    IAcceptanceResult6 IMandateAcceptance3.AcceptanceResult => AcceptanceResult;
    IOriginalMandate2Choice IMandateAcceptance3.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAcceptance3.SupplementaryData => SupplementaryData;
}
