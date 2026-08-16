// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class BelgianIdentifierTests : SimpleValueStringContractTests<BelgianIdentifier>
{
    protected override string ValidSample => "123456";
    protected override string InvalidSample => "";
}
