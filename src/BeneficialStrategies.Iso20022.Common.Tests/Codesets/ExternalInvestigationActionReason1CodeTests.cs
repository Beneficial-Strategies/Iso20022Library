// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalInvestigationActionReason1CodeTests : ExternalCodesetContractTests<ExternalInvestigationActionReason1Code>
{
    protected override string ValidSample => "IRCD";
    protected override string InvalidSample => "TOOLONG";
}
