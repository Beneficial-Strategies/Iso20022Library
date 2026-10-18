// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RateSourceTextTests : SimpleValueStringContractTests<RateSourceText>
{
    protected override string ValidSample => "USD01";
    protected override string InvalidSample => "US";
}
