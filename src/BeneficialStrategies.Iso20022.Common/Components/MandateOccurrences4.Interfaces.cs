// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateOccurrences4 : IMandateOccurrences4
{
    IFrequency36Choice? IMandateOccurrences4.Frequency => Frequency;
    IDatePeriodDetails1? IMandateOccurrences4.Duration => Duration;
}
