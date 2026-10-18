// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance2 : IMandateAcceptance2
{
    IOriginalMessageInformation1? IMandateAcceptance2.OriginalMessageInformation => OriginalMessageInformation;
    IAcceptanceResult6 IMandateAcceptance2.AcceptanceResult => AcceptanceResult;
    IOriginalMandate2Choice IMandateAcceptance2.OriginalMandate => OriginalMandate;
}
