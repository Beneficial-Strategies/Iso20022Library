// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max35BinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Max35Binary>
{
    protected override int MaxLength => 35;
}
