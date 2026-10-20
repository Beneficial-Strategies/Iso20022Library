// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583MessageErrorCodeTests : ExternalCodesetContractTests<ISO8583MessageErrorCode>
{
    protected override string ValidSample => "1001";
    protected override string InvalidSample => "100";
}
