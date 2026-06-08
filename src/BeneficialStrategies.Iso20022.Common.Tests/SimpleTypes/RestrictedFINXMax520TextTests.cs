// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINXMax520TextTests : SimpleValueRestrictedFINXTextContractTests<RestrictedFINXMax520Text>
{
    protected override int MaxLength => 520;
}
