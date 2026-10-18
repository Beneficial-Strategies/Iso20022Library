// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance4 : IMandateAcceptance4
{
    IOriginalMessageInformation1? IMandateAcceptance4.OriginalMessageInformation => OriginalMessageInformation;
    IAcceptanceResult6 IMandateAcceptance4.AcceptanceResult => AcceptanceResult;
    IOriginalMandate3Choice IMandateAcceptance4.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAcceptance4.SupplementaryData => SupplementaryData;
}
