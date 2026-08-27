// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalCashTypeCodeTests : ExternalCodesetContractTests<ExternalCashTypeCode>
{
    protected override string ValidSample => "CASH";
    protected override string InvalidSample => "TOOLONG";
}
