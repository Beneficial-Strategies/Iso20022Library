// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max9999HexBinaryTextTests : SimpleValueStringContractTests<Max9999HexBinaryText>
{
    protected override string ValidSample   => "1A2B3C4D";
    protected override string InvalidSample => "lowercase";
}
