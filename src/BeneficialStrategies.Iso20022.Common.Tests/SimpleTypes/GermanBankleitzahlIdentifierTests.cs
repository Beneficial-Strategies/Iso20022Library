// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class GermanBankleitzahlIdentifierTests : SimpleValueStringContractTests<GermanBankleitzahlIdentifier>
{
    protected override string ValidSample   => "BL12345678";
    protected override string InvalidSample => "XX12345678";
}
