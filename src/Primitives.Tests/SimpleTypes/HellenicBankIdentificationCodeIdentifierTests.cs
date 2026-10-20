// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class HellenicBankIdentificationCodeIdentifierTests : SimpleValueStringContractTests<HellenicBankIdentificationCodeIdentifier>
{
    protected override string ValidSample => "GR1234567";
    protected override string InvalidSample => "XX1234567";
}
