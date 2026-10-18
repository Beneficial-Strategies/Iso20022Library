// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalCashType1CodeTests : ExternalCodesetContractTests<ExternalCashType1Code>
{
    protected override string ValidSample => "CASH";
    protected override string InvalidSample => "TOOLONG";
}
