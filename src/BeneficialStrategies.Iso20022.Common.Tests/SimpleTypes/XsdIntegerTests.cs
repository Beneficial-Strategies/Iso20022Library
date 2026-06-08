// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdIntegerTests : SimpleValueXsdNumericContractTests<XsdInteger, long>
{
    protected override long ValidNativeSample => 42L;
}
