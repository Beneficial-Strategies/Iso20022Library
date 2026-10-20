// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max500BinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Max500Binary>
{
    protected override int MaxLength => 500;
}
