// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class UnicodeChartsCodeTests : ExternalCodesetContractTests<UnicodeChartsCode>
{
    protected override string ValidSample => "Basic Latin";
    protected override string InvalidSample => "";
}
