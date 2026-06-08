// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max20KTextTests : SimpleValueMaxTextContractTests<Max20KText>
{
    protected override int MinLength => 1;
    protected override int MaxLength => 20000;
}
