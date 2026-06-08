// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class MICIdentifierTests : SimpleValueStringContractTests<MICIdentifier>
{
    protected override string ValidSample   => "XLON";
    protected override string InvalidSample => "X!ON";
}
