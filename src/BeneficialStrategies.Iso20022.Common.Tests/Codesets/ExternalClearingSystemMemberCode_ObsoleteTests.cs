// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalClearingSystemMemberCode_ObsoleteTests : ExternalCodesetContractTests<ExternalClearingSystemMemberCode_Obsolete>
{
    protected override string ValidSample => "GBSC";
    protected override string InvalidSample => "ThisStringExceedsTheMaximumAllowedThirtyFiveCharacterLimit";
}
