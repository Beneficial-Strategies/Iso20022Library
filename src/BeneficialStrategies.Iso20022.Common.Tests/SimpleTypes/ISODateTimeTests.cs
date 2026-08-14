// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISODateTimeTests : SimpleValueXsdGregorianScalarContractTests<ISODateTime, DateTime>
{
    protected override DateTime ValidNativeSample => new(2026, 8, 13, 10, 30, 0);
    protected override string ValidNativeSampleWireCore => "2026-08-13T10:30:00";
}
