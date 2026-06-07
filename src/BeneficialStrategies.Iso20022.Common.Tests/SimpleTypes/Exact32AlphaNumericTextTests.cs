// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact32AlphaNumericTextTests : SimpleValueAlphaNumericTextContractTests<Exact32AlphaNumericText>
{
    protected override int MinLength => 32;
    protected override int MaxLength => 32;
}
