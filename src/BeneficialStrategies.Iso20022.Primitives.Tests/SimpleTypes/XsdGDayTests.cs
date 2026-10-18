// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdGDayTests : SimpleValueXsdGregorianScalarRangeConstrainedContractTests<XsdGDay, byte>
{
    protected override byte ValidNativeSample => 15;
    protected override string ValidNativeSampleWireCore => "---15";
    protected override byte OutOfRangeNativeSample => 32;
}
