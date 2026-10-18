// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max4000TextTests : SimpleValueMaxTextContractTests<Max4000Text>
{
    protected override int MaxLength => 4000;
}
