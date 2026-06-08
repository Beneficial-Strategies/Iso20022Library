// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class SwissBCIdentifierTests : SimpleValueStringContractTests<SwissBCIdentifier>
{
    protected override string ValidSample   => "SW123";
    protected override string InvalidSample => "XX123";
}
