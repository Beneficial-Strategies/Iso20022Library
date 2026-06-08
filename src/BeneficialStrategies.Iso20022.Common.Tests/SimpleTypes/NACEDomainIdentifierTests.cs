// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class NACEDomainIdentifierTests : SimpleValueStringContractTests<NACEDomainIdentifier>
{
    protected override string ValidSample => "A";
    protected override string InvalidSample => "V";
}
