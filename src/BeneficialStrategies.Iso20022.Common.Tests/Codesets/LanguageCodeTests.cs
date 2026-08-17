// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class LanguageCodeTests : ExternalCodesetContractTests<LanguageCode>
{
    protected override string ValidSample => "en";
    protected override string InvalidSample => "";
}
