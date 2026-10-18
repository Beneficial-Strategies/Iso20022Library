// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateTypeInformation1 : IMandateTypeInformation1
{
    IServiceLevel8Choice? IMandateTypeInformation1.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IMandateTypeInformation1.LocalInstrument => LocalInstrument;
}
