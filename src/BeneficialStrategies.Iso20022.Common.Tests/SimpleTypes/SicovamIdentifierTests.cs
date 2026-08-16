// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class SicovamIdentifierTests : SimpleValueStringContractTests<SicovamIdentifier>
{
    protected override string ValidSample => "12345";
    protected override string InvalidSample => "1234"; // Sicovam is 5-digit only
}
