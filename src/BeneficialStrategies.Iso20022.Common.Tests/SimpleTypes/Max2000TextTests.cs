// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max2000TextTests : SimpleValueMaxTextContractTests<Max2000Text>
{
    protected override int MaxLength => 2000;
}
