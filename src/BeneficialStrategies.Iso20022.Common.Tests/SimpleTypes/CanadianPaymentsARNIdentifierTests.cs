// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class CanadianPaymentsARNIdentifierTests : SimpleValueStringContractTests<CanadianPaymentsARNIdentifier>
{
    protected override string ValidSample   => "CA123456789";
    protected override string InvalidSample => "US123456789";
}
