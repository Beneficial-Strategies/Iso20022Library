// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class CountryCodeTests : ExternalCodesetContractTests<CountryCode>
{
    protected override string ValidSample => "US";
    protected override string InvalidSample => "123";
}
