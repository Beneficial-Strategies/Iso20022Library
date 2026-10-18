// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance6 : IMandateAcceptance6
{
    IOriginalMessageInformation1? IMandateAcceptance6.OriginalMessageInformation => OriginalMessageInformation;
    IAcceptanceResult6 IMandateAcceptance6.AcceptanceResult => AcceptanceResult;
    IOriginalMandate7Choice? IMandateAcceptance6.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAcceptance6.SupplementaryData => SupplementaryData;
}
