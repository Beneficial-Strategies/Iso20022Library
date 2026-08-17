// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class PositiveNumberTests : SimpleValueXsdConstrainedLongContractTests<PositiveNumber>
{
    protected override long ValidNativeSample => 1;
    protected override long OutOfRangeNativeSample => 0;
}
