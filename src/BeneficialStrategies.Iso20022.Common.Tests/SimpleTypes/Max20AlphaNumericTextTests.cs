// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max20AlphaNumericTextTests : SimpleValueAlphaNumericTextContractTests<Max20AlphaNumericText>
{
    protected override int MaxLength => 20;
}
