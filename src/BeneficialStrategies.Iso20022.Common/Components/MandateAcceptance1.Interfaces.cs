// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAcceptance1 : IMandateAcceptance1
{
    IOriginalMessageInformation1? IMandateAcceptance1.OriginalMessageInformation => OriginalMessageInformation;
    IAcceptanceResult6 IMandateAcceptance1.AcceptanceResult => AcceptanceResult;
    IOriginalMandate1Choice IMandateAcceptance1.OriginalMandate => OriginalMandate;
}
