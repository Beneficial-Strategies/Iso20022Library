// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdIntTests : SimpleValueXsdNumericContractTests<XsdInt, int>
{
    protected override int ValidNativeSample => 42;
}
