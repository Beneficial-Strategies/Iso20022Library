// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINZMax2048TextTests : SimpleValueRestrictedFINZTextContractTests<RestrictedFINZMax2048Text>
{
    protected override int MaxLength => 2048;
}
