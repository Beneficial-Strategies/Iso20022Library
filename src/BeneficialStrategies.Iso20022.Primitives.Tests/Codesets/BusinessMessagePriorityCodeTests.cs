// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class BusinessMessagePriorityCodeTests
    : ExternalCodesetContractTests<BusinessMessagePriorityCode>
{
    protected override string ValidSample => "NORM";
    protected override string InvalidSample => "not_valid_123";
}
