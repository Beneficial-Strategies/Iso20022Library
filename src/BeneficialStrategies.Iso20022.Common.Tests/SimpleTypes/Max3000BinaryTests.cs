// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max3000BinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Max3000Binary>
{
    protected override int MaxLength => 3000;
}
