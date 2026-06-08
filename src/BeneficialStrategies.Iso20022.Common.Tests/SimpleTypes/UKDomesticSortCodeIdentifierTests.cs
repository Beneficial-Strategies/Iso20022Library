// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class UKDomesticSortCodeIdentifierTests : SimpleValueStringContractTests<UKDomesticSortCodeIdentifier>
{
    protected override string ValidSample   => "SC123456";
    protected override string InvalidSample => "XX123456";
}
