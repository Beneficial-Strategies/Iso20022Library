// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact14NumericTextTests : SimpleValueNumericTextContractTests<Exact14NumericText>
{
    protected override int MinLength => 14;
    protected override int MaxLength => 14;
}
