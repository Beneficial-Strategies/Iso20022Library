// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

[Obsolete("The type being testedwill be removed in a future major version.")]
public class AnyBICIdentifierTests : SimpleValueStringContractTests<AnyBICIdentifier>
{
    protected override string ValidSample => "DEUTDEDB";
    protected override string InvalidSample => "12345678";
}
