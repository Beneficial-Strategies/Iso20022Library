// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdGYearTests : SimpleValueXsdGregorianScalarContractTests<XsdGYear, int>
{
    protected override int ValidNativeSample => 2026;
    protected override string ValidNativeSampleWireCore => "2026";
}
