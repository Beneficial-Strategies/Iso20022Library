// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max5NumberTests : SimpleValueXsdConstrainedLongContractTests<Max5Number>
{
    protected override long ValidNativeSample => 12345;
    protected override long OutOfRangeNativeSample => 100000;
}
