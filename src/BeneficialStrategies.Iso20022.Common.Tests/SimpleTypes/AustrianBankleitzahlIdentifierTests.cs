// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class AustrianBankleitzahlIdentifierTests : SimpleValueStringContractTests<AustrianBankleitzahlIdentifier>
{
    protected override string ValidSample   => "AT12345";
    protected override string InvalidSample => "XX12345";
}
