// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max5000BinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Max5000Binary>
{
    protected override int MaxLength => 5000;
}
