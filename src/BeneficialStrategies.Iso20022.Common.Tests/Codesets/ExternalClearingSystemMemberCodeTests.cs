// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

[Obsolete("The type being tested is obsolete in the ISO 20022 specification.")]
public class ExternalClearingSystemMemberCodeTests : ExternalCodesetContractTests<ExternalClearingSystemMemberCode>
{
    protected override string ValidSample => "ABC123";
    protected override string InvalidSample => "";
}
