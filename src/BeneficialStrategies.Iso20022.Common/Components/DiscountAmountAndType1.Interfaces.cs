// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DiscountAmountAndType1 : IDiscountAmountAndType1
{
    IDiscountAmountType1Choice? IDiscountAmountAndType1.Type => Type;
}
