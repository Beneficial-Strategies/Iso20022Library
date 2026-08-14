// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISONormalisedDateTimeTests : SimpleValueCompositeScalarContractTests<ISONormalisedDateTime, DateTime>
{
    protected override DateTime ValidNativeSample => new(2026, 8, 13, 10, 30, 0, DateTimeKind.Utc);
    protected override string ValidWireText => "2026-08-13T10:30:00Z";

    // Missing the mandatory "Z" — otherwise a validly-formed ISODateTime, so this specifically
    // exercises the ISONormalisedDateTime-only "must end in Z" constraint (pattern .*Z).
    protected override string InvalidWireText => "2026-08-13T10:30:00";
}
