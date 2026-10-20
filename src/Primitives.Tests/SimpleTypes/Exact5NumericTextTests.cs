// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact5NumericTextTests : SimpleValueNumericTextContractTests<Exact5NumericText>
{
    protected override int MinLength => 5;
    protected override int MaxLength => 5;
}
