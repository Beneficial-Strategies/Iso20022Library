// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class CurrencyCodeTests : ExternalCodesetContractTests<CurrencyCode>
{
    protected override string ValidSample => "USD";
    protected override string InvalidSample => "US";
}
