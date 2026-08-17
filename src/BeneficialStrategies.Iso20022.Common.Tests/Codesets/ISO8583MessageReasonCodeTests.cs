// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583MessageReasonCodeTests : ExternalCodesetContractTests<ISO8583MessageReasonCode>
{
    protected override string ValidSample => "4021";
    protected override string InvalidSample => "402";
}
