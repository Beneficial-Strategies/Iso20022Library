// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max10DateTextTests : SimpleValueStringContractTests<Max10DateText>
{
    protected override string ValidSample   => "2024-03-15";
    protected override string InvalidSample => "NOTADATE";
}
