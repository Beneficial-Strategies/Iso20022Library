// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance5 : IMandateAcceptance5
{
    IOriginalMessageInformation1? IMandateAcceptance5.OriginalMessageInformation => OriginalMessageInformation;
    IAcceptanceResult6 IMandateAcceptance5.AcceptanceResult => AcceptanceResult;
    IOriginalMandate5Choice? IMandateAcceptance5.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAcceptance5.SupplementaryData => SupplementaryData;
}
