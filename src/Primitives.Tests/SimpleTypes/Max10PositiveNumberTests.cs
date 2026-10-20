// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max10PositiveNumberTests : SimpleValueXsdConstrainedLongContractTests<Max10PositiveNumber>
{
    protected override long ValidNativeSample => 1;
    protected override long OutOfRangeNativeSample => 10000000000;
}
