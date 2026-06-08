// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class BICFIIdentifierTests : SimpleValueStringContractTests<BICFIIdentifier>
{
    protected override string ValidSample   => "DEUTDEDB";
    protected override string InvalidSample => "12345678";
}
