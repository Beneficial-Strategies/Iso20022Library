// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNonNegativeIntegerTests : SimpleValueXsdConstrainedLongContractTests<XsdNonNegativeInteger>
{
    protected override long ValidNativeSample   => 0L;
    protected override long OutOfRangeNativeSample => -1L;
}
