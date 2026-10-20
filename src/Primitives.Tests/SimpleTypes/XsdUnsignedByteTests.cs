// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdUnsignedByteTests : SimpleValueXsdNumericContractTests<XsdUnsignedByte, byte>
{
    protected override byte ValidNativeSample => (byte)200;
}
