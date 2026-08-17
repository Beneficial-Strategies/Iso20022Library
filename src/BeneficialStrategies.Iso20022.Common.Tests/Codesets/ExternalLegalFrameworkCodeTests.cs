// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalLegalFrameworkCodeTests : ExternalCodesetContractTests<ExternalLegalFrameworkCode>
{
    protected override string ValidSample => "ABCDEF";
    protected override string InvalidSample => "";
}
