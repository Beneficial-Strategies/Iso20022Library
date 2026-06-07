// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class CountrySubDivisionCodeTests : ExternalCodesetContractTests<CountrySubDivisionCode>
{
    protected override string ValidSample => "US-CA";
    protected override string InvalidSample => "INVALID";
}
