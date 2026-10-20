// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class BusinessFilePriorityCodeTests : ExternalCodesetContractTests<BusinessFilePriorityCode>
{
    protected override string ValidSample => "HIGH";
    protected override string InvalidSample => "";
}
