// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class NonNegativeNumberTests : SimpleValueXsdConstrainedLongContractTests<NonNegativeNumber>
{
    protected override long ValidNativeSample => 0;
    protected override long OutOfRangeNativeSample => -1;
}
