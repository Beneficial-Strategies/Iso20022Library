// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class EuroCurrencyCodeTests : ExternalCodesetContractTests<EuroCurrencyCode>
{
    protected override string ValidSample => "EUR";
    protected override string InvalidSample => "USD";
}
