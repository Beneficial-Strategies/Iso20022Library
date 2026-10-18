// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxRecord1 : ITaxRecord1
{
    ITaxPeriod1? ITaxRecord1.Period => Period;
    ITaxAmount1? ITaxRecord1.TaxAmount => TaxAmount;
}
