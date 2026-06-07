// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max35NumericTextTests : SimpleValueNumericTextContractTests<Max35NumericText>
{
    protected override int MaxLength => 35;
}
