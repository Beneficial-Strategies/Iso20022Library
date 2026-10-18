// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AdviceType1 : IAdviceType1
{
    IAdviceType1Choice? IAdviceType1.CreditAdvice => CreditAdvice;
    IAdviceType1Choice? IAdviceType1.DebitAdvice => DebitAdvice;
}
