// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalInvestigationStatusCodeTests : ExternalCodesetContractTests<ExternalInvestigationStatusCode>
{
    protected override string ValidSample => "CLSD";
    protected override string InvalidSample => "TOOLONG";
}
