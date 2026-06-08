// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINMax8TextTests : SimpleValueRestrictedFINSlashTextContractTests<RestrictedFINMax8Text>
{
    protected override int MaxLength => 8;
}
