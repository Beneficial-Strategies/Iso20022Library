// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance8 : IMandateAcceptance8
{
    IAcceptanceResult6 IMandateAcceptance8.AcceptanceResult => AcceptanceResult;
    IOriginalMandate11Choice? IMandateAcceptance8.OriginalMandate => OriginalMandate;
    IOriginalMessageInformation1? IMandateAcceptance8.OriginalMessageInformation => OriginalMessageInformation;
    IEnumerable<ISupplementaryData1> IMandateAcceptance8.SupplementaryData => SupplementaryData;
}
