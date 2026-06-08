// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISO20022MessageIdentificationTextTests : SimpleValueStringContractTests<ISO20022MessageIdentificationText>
{
    protected override string ValidSample   => "pain.001.001.12";
    protected override string InvalidSample => "INVALID";
}
