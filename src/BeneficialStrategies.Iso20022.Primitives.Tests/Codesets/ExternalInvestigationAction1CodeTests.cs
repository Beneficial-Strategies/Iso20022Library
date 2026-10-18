// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalInvestigationAction1CodeTests : ExternalCodesetContractTests<ExternalInvestigationAction1Code>
{
    protected override string ValidSample => "RQCL";
    protected override string InvalidSample => "TOOLONG";
}
