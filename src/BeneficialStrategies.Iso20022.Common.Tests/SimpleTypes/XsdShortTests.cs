// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdShortTests : SimpleValueXsdNumericContractTests<XsdShort, short>
{
    protected override short ValidNativeSample => (short)42;
}
