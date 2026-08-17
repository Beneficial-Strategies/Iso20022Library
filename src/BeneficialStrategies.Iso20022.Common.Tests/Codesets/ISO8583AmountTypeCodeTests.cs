// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583AmountTypeCodeTests : ExternalCodesetContractTests<ISO8583AmountTypeCode>
{
    protected override string ValidSample => "01";
    protected override string InvalidSample => "1";
}
