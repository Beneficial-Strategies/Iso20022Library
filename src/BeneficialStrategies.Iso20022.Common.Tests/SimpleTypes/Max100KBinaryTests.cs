// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max100KBinaryTests : SimpleValueXsdLengthConstrainedBinaryContractTests<Max100KBinary>
{
    protected override int MaxLength => 102400;
}
