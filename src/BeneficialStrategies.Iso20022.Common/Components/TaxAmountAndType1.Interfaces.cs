// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxAmountAndType1 : ITaxAmountAndType1
{
    ITaxAmountType1Choice? ITaxAmountAndType1.Type => Type;
}
