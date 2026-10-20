// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINXMax24TextTests : SimpleValueRestrictedFINXSlashTextContractTests<RestrictedFINXMax24Text>
{
    protected override int MaxLength => 24;
}
