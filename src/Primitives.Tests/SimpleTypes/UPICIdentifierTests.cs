// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class UPICIdentifierTests : SimpleValueStringContractTests<UPICIdentifier>
{
    protected override string ValidSample => "12345678";
    protected override string InvalidSample => "1234567";
}
