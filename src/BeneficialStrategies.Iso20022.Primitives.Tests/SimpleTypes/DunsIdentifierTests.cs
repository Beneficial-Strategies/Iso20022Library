// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class DunsIdentifierTests : SimpleValueStringContractTests<DunsIdentifier>
{
    protected override string ValidSample => "123456789";
    protected override string InvalidSample => "NOTADUNS";
}
