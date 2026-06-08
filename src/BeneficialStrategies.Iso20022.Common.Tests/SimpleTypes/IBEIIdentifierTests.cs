// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class IBEIIdentifierTests : SimpleValueStringContractTests<IBEIIdentifier>
{
    protected override string ValidSample   => "GB00000001";
    protected override string InvalidSample => "NOTIBEI!";
}
