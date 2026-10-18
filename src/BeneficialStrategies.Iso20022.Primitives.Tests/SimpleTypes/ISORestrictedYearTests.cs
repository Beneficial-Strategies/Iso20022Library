// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISORestrictedYearTests : SimpleValueXsdConstrainedLongContractTests<ISORestrictedYear>
{
    protected override long ValidNativeSample => 2026;
    protected override long OutOfRangeNativeSample => 1899;
}
