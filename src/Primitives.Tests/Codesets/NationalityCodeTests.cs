// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class NationalityCodeTests : ExternalCodesetContractTests<NationalityCode>
{
    protected override string ValidSample => "US";
    protected override string InvalidSample => "";
}
