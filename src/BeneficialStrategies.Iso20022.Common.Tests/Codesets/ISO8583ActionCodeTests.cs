// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583ActionCodeTests : ExternalCodesetContractTests<ISO8583ActionCode>
{
    protected override string ValidSample => "100";
    protected override string InvalidSample => "10";
}
