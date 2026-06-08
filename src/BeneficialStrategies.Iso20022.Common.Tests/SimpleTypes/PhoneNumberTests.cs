// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class PhoneNumberTests : SimpleValueStringContractTests<PhoneNumber>
{
    protected override string ValidSample   => "+1-2125551234";
    protected override string InvalidSample => "notaphone";
}
