// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

[Obsolete("The type being testedwill be removed in a future major version.")]
public class CFIIdentifierTests : SimpleValueStringContractTests<CFIIdentifier>
{
    protected override string ValidSample => "ESXXXX";
    protected override string InvalidSample => "1234567";
}
