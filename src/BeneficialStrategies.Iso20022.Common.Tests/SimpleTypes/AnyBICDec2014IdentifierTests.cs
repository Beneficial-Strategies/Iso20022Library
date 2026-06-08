// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class AnyBICDec2014IdentifierTests : SimpleValueStringContractTests<AnyBICDec2014Identifier>
{
    protected override string ValidSample   => "DEUTDEBB";
    protected override string InvalidSample => "!NOTBIC";
}
