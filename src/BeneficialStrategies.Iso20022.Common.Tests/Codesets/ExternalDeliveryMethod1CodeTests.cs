// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalDeliveryMethod1CodeTests : ExternalCodesetContractTests<ExternalDeliveryMethod1Code>
{
    protected override string ValidSample => "MAIL";
    protected override string InvalidSample => "TOOLONG";
}
