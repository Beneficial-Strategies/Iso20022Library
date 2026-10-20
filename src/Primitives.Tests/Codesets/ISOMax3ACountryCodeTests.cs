// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISOMax3ACountryCodeTests : ExternalCodesetContractTests<ISOMax3ACountryCode>
{
    protected override string ValidSample => "US";
    protected override string InvalidSample => "U";
}
