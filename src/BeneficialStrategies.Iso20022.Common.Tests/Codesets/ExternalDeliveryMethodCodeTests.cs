// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalDeliveryMethodCodeTests : ExternalCodesetContractTests<ExternalDeliveryMethodCode>
{
    protected override string ValidSample => "MAIL";
    protected override string InvalidSample => "TOOLONG";
}
