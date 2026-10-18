// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINZMax8000TextTests : SimpleValueRestrictedFINZTextContractTests<RestrictedFINZMax8000Text>
{
    protected override int MaxLength => 8000;
}
