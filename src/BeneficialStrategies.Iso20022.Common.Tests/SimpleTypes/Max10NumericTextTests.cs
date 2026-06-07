// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max10NumericTextTests : SimpleValueNumericTextContractTests<Max10NumericText>
{
    protected override int MaxLength => 10;
}
