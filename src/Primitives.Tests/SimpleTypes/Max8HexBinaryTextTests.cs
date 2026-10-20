// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max8HexBinaryTextTests : SimpleValueStringContractTests<Max8HexBinaryText>
{
    protected override string ValidSample => "1A2B3C4D";
    protected override string InvalidSample => "lowercase";
}
