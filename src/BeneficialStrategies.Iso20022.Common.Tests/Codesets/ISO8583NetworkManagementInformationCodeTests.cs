// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583NetworkManagementInformationCodeTests : ExternalCodesetContractTests<ISO8583NetworkManagementInformationCode>
{
    protected override string ValidSample => "301";
    protected override string InvalidSample => "30";
}
