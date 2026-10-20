// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583AccountTypeCodeTests : ExternalCodesetContractTests<ISO8583AccountTypeCode>
{
    protected override string ValidSample => "00";
    protected override string InvalidSample => "0";
}
