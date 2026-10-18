// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

[Obsolete("The BEIIdentifier type is deprecated in favor of BICIdentifier. It will be removed in a future major version.")]
public class BEIIdentifierTests : SimpleValueStringContractTests<BEIIdentifier>
{
    protected override string ValidSample => "DEUTDEDB";
    protected override string InvalidSample => "12345678";
}
