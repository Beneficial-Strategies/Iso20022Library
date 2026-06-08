// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdUnsignedShortTests : SimpleValueXsdNumericContractTests<XsdUnsignedShort, ushort>
{
    protected override ushort ValidNativeSample => (ushort)42;
}
