// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact2AlphaNumericTextTests : SimpleValueAlphaNumericTextContractTests<Exact2AlphaNumericText>
{
    protected override int MinLength => 2;
    protected override int MaxLength => 2;
}
