// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class IndianFinancialSystemCodeIdentifierTests : SimpleValueStringContractTests<IndianFinancialSystemCodeIdentifier>
{
    protected override string ValidSample => "INIDFB0110001";
    protected override string InvalidSample => "XX1234567890A";
}
