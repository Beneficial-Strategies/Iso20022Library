// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO3NumericCountryCodeTests : ExternalCodesetContractTests<ISO3NumericCountryCode>
{
    protected override string ValidSample => "840";
    protected override string InvalidSample => "84";
}
