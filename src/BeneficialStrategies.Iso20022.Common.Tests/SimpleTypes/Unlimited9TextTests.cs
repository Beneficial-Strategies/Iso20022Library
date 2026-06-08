// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Unlimited9TextTests : SimpleValueStringContractTests<Unlimited9Text>
{
    protected override string ValidSample   => "UNLIMITED";
    protected override string InvalidSample => "LIMITED";
}
