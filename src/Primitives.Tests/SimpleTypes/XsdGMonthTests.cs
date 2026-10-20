// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdGMonthTests : SimpleValueXsdGregorianScalarRangeConstrainedContractTests<XsdGMonth, byte>
{
    protected override byte ValidNativeSample => 6;
    protected override string ValidNativeSampleWireCore => "--06";
    protected override byte OutOfRangeNativeSample => 13;
}
