// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max10MbBinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Max10MbBinary>
{
    protected override int MaxLength => 10485760;
}
