// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalLegalFramework1CodeTests : ExternalCodesetContractTests<ExternalLegalFramework1Code>
{
    protected override string ValidSample => "ABCDEF";
    protected override string InvalidSample => "";
}
