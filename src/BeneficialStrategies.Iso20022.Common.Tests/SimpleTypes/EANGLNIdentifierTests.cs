// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class EANGLNIdentifierTests : SimpleValueStringContractTests<EANGLNIdentifier>
{
    protected override string ValidSample   => "1234567890123";
    protected override string InvalidSample => "NOTEAN123456789";
}
