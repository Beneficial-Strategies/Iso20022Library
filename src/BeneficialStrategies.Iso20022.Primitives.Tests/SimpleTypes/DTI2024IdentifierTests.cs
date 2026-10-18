// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class DTI2024IdentifierTests : SimpleValueStringContractTests<DTI2024Identifier>
{
    protected override string ValidSample => "123456789";
    protected override string InvalidSample => "012345678";
}
