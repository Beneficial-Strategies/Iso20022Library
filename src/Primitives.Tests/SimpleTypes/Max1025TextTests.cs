// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max1025TextTests : SimpleValueMaxTextContractTests<Max1025Text>
{
    protected override int MaxLength => 1025;
}
