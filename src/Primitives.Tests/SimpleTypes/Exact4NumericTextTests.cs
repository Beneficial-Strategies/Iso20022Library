// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact4NumericTextTests : SimpleValueNumericTextContractTests<Exact4NumericText>
{
    protected override int MinLength => 4;
    protected override int MaxLength => 4;
}
