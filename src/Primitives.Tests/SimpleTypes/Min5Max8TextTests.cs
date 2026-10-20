// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Min5Max8TextTests : SimpleValueMaxTextContractTests<Min5Max8Text>
{
    protected override int MinLength => 5;
    protected override int MaxLength => 8;
}
