// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Bloomberg2IdentifierTests : SimpleValueStringContractTests<Bloomberg2Identifier>
{
    protected override string ValidSample => "BBG000B9XRZ4";
    protected override string InvalidSample => "NOTBLOOMBERG";
}
