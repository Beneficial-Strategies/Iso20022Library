// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact2NumericTextTests : SimpleValueNumericTextContractTests<Exact2NumericText>
{
    protected override int MinLength => 2;
    protected override int MaxLength => 2;
}
