// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdByteTests : SimpleValueXsdNumericContractTests<XsdByte, sbyte>
{
    protected override sbyte ValidNativeSample => (sbyte)42;
}
