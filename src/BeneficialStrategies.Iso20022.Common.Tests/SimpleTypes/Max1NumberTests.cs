// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max1NumberTests : SimpleValueXsdConstrainedLongContractTests<Max1Number>
{
    protected override long ValidNativeSample => 5;
    protected override long OutOfRangeNativeSample => 10;
}
