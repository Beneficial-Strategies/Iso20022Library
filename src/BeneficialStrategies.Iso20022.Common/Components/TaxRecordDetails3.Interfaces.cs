// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxRecordDetails3 : ITaxRecordDetails3
{
    ITaxPeriod3? ITaxRecordDetails3.Period => Period;
}
