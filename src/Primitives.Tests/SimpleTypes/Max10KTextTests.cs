// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max10KTextTests : SimpleValueMaxTextContractTests<Max10KText>
{
    protected override int MinLength => 1;
    protected override int MaxLength => 10000;
}
