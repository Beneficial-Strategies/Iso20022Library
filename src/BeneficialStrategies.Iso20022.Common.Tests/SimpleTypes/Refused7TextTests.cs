// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Refused7TextTests : SimpleValueStringContractTests<Refused7Text>
{
    protected override string ValidSample   => "REFUSED";
    protected override string InvalidSample => "OTHER";
}
