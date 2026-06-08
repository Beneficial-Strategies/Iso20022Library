// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ELFIdentifierTests : SimpleValueStringContractTests<ELFIdentifier>
{
    protected override string ValidSample   => "2AKL";
    protected override string InvalidSample => "!ABC";
}
