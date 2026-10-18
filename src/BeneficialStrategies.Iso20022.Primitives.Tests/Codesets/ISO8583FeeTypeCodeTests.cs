// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583FeeTypeCodeTests : ExternalCodesetContractTests<ISO8583FeeTypeCode>
{
    protected override string ValidSample => "01";
    protected override string InvalidSample => "1";
}
