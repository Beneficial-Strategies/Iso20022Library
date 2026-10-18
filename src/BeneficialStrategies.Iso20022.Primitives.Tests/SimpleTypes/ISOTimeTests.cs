// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISOTimeTests : SimpleValueXsdGregorianScalarContractTests<ISOTime, TimeOnly>
{
    protected override TimeOnly ValidNativeSample => new(10, 30, 0);
    protected override string ValidNativeSampleWireCore => "10:30:00";
}
