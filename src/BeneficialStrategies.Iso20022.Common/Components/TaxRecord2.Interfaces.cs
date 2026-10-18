// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxRecord2 : ITaxRecord2
{
    ITaxPeriod2? ITaxRecord2.Period => Period;
    ITaxAmount2? ITaxRecord2.TaxAmount => TaxAmount;
}
