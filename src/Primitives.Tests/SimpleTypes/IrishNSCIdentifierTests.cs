// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class IrishNSCIdentifierTests : SimpleValueStringContractTests<IrishNSCIdentifier>
{
    protected override string ValidSample => "IE123456";
    protected override string InvalidSample => "XX123456";
}
