// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNonPositiveIntegerTests : SimpleValueXsdConstrainedLongContractTests<XsdNonPositiveInteger>
{
    protected override long ValidNativeSample => 0L;
    protected override long OutOfRangeNativeSample => 1L;
}
