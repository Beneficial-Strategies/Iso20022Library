// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Min1Max256BinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Min1Max256Binary>
{
    protected override int MaxLength => 256;
}
