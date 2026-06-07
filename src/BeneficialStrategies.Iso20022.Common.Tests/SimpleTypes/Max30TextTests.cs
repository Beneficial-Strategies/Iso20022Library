// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max30TextTests : SimpleValueMaxTextContractTests<Max30Text>
{
    protected override int MinLength => 0;
    protected override int MaxLength => 30;
}
