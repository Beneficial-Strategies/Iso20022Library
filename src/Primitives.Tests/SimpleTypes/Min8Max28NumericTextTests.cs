// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Min8Max28NumericTextTests : SimpleValueNumericTextContractTests<Min8Max28NumericText>
{
    protected override int MinLength => 8;
    protected override int MaxLength => 28;
}
