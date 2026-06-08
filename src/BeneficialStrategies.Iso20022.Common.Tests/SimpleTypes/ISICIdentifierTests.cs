// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISICIdentifierTests : SimpleValueStringContractTests<ISICIdentifier>
{
    protected override string ValidSample   => "A1234";
    protected override string InvalidSample => "V1234";
}
