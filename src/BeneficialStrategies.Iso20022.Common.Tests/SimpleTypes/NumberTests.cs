// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class NumberTests : SimpleValueXsdConstrainedLongContractTests<Number>
{
    protected override long ValidNativeSample => 42;
    protected override long OutOfRangeNativeSample => 1000000000000000000;
}
