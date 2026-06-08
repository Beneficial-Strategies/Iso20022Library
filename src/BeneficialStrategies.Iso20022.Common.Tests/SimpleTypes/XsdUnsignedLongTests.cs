// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdUnsignedLongTests : SimpleValueXsdNumericContractTests<XsdUnsignedLong, ulong>
{
    protected override ulong ValidNativeSample => 42ul;
}
