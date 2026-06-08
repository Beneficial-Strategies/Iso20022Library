// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class HexBinaryTextTests : SimpleValueStringContractTests<HexBinaryText>
{
    protected override string ValidSample => "DEADBEEF";
    protected override string InvalidSample => "INVALID!";
}
