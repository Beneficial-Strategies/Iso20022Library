// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINMax35TextTests : SimpleValueRestrictedFINSlashTextContractTests<RestrictedFINMax35Text>
{
    protected override int MaxLength => 35;
}
