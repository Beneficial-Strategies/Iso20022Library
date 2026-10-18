// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Min5Max16BinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Min5Max16Binary>
{
    protected override int MinLength => 5;
    protected override int MaxLength => 16;
}
