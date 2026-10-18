// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateOccurrences5 : IMandateOccurrences5
{
    IFrequency36Choice? IMandateOccurrences5.Frequency => Frequency;
    IDatePeriod3? IMandateOccurrences5.Duration => Duration;
}
