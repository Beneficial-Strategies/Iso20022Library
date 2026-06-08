// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class PortugueseNCCIdentifierTests : SimpleValueStringContractTests<PortugueseNCCIdentifier>
{
    protected override string ValidSample   => "PT12345678";
    protected override string InvalidSample => "XX12345678";
}
