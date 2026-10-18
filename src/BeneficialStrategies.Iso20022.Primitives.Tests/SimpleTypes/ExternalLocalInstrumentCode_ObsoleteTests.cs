// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

[Obsolete("The type being testedwill be removed in a future major version.")]
public class ExternalLocalInstrumentCode_ObsoleteTests : SimpleValueMaxTextContractTests<ExternalLocalInstrumentCode_Obsolete>
{
    protected override int MinLength => 1;
    protected override int MaxLength => 35;
}
