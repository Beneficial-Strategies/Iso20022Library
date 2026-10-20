// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact7NumericTextTests : SimpleValueNumericTextContractTests<Exact7NumericText>
{
    protected override int MinLength => 7;
    protected override int MaxLength => 7;
}
