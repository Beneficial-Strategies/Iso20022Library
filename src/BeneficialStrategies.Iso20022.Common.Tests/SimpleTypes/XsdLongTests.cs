// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdLongTests : SimpleValueXsdNumericContractTests<XsdLong, long>
{
    protected override long ValidNativeSample => 42L;
}
