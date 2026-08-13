// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdBase64BinaryTests : SimpleValueXsdBinaryContractTests<XsdBase64Binary>
{
    protected override byte[] ValidNativeSample => [0x01, 0x02, 0x03, 0xFF];
    protected override string ValidNativeSampleWireText => Convert.ToBase64String([0x01, 0x02, 0x03, 0xFF]);
}
