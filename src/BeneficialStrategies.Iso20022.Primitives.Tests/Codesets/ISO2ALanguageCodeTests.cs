// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO2ALanguageCodeTests : ExternalCodesetContractTests<ISO2ALanguageCode>
{
    protected override string ValidSample => "en";
    protected override string InvalidSample => "eng";
}
