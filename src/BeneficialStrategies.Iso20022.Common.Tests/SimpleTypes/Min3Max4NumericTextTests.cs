// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Min3Max4NumericTextTests : SimpleValueNumericTextContractTests<Min3Max4NumericText>
{
    protected override int MinLength => 3;
    protected override int MaxLength => 4;
}
