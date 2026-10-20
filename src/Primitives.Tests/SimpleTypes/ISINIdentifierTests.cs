// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

[Obsolete("The type being testedwill be removed in a future major version.")]
public class ISINIdentifierTests : SimpleValueStringContractTests<ISINIdentifier>
{
    protected override string ValidSample => "US0378331005";
    protected override string InvalidSample => "TOOSHORT";
}
