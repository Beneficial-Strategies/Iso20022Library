// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNegativeIntegerTests : SimpleValueXsdConstrainedLongContractTests<XsdNegativeInteger>
{
    protected override long ValidNativeSample   => -42L;
    protected override long OutOfRangeNativeSample => 0L;
}
