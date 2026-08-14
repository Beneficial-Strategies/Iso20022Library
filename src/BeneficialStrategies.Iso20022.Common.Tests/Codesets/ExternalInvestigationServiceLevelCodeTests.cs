// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalInvestigationServiceLevelCodeTests : ExternalCodesetContractTests<ExternalInvestigationServiceLevelCode>
{
    protected override string ValidSample => "R01D";
    protected override string InvalidSample => "TOOLONG";
}
