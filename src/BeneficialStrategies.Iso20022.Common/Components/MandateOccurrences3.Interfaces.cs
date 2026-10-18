// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateOccurrences3 : IMandateOccurrences3
{
    IFrequency21Choice? IMandateOccurrences3.Frequency => Frequency;
    IDatePeriodDetails1? IMandateOccurrences3.Duration => Duration;
}
