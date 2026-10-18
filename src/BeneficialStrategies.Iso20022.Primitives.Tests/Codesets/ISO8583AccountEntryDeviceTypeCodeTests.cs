// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISO8583AccountEntryDeviceTypeCodeTests : ExternalCodesetContractTests<ISO8583AccountEntryDeviceTypeCode>
{
    protected override string ValidSample => "1";
    protected override string InvalidSample => "12";
}
