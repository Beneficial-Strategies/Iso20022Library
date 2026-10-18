// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateOccurrences1 : IMandateOccurrences1
{
    IDatePeriodDetails1? IMandateOccurrences1.Duration => Duration;
}
