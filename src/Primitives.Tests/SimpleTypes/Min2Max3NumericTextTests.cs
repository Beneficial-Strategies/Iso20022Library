// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Min2Max3NumericTextTests : SimpleValueNumericTextContractTests<Min2Max3NumericText>
{
    protected override int MinLength => 2;
    protected override int MaxLength => 3;
}
