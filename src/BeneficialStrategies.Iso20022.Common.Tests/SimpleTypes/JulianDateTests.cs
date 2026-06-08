// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class JulianDateTests : SimpleValueStringContractTests<JulianDate>
{
    protected override string ValidSample => "1001";
    protected override string InvalidSample => "9999";
}
