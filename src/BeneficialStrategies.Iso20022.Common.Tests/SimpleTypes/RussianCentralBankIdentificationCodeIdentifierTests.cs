// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RussianCentralBankIdentificationCodeIdentifierTests : SimpleValueStringContractTests<RussianCentralBankIdentificationCodeIdentifier>
{
    protected override string ValidSample => "RU123456789";
    protected override string InvalidSample => "XX123456789";
}
