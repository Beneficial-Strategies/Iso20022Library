// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max3NumberTests : SimpleValueXsdConstrainedLongContractTests<Max3Number>
{
    protected override long ValidNativeSample => 500;
    protected override long OutOfRangeNativeSample => 1000;
}
