// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance7 : IMandateAcceptance7
{
    IOriginalMessageInformation1? IMandateAcceptance7.OriginalMessageInformation => OriginalMessageInformation;
    IAcceptanceResult6 IMandateAcceptance7.AcceptanceResult => AcceptanceResult;
    IOriginalMandate8Choice? IMandateAcceptance7.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAcceptance7.SupplementaryData => SupplementaryData;
}
