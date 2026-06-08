// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class UTIIdentifierTests : SimpleValueStringContractTests<UTIIdentifier>
{
    protected override string ValidSample   => "AAAAAAAAAAAAAAAAAA12";
    protected override string InvalidSample => "TOOSHORT";
}
