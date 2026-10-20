// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact4AlphaNumericTextTests : SimpleValueAlphaNumericTextContractTests<Exact4AlphaNumericText>
{
    protected override int MinLength => 4;
    protected override int MaxLength => 4;
}
