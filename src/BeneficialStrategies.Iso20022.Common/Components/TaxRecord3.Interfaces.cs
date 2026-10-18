// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxRecord3 : ITaxRecord3
{
    ITaxPeriod3? ITaxRecord3.Period => Period;
    ITaxAmount3? ITaxRecord3.TaxAmount => TaxAmount;
}
