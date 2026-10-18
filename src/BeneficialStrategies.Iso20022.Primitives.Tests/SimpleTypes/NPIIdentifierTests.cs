// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class NPIIdentifierTests : SimpleValueStringContractTests<NPIIdentifier>
{
    // Per ISO 24366:2021 text: 13 upper-case alphanumeric characters followed by 2 check digits.
    protected override string ValidSample => "ABCDEFGHIJKLM12";
    protected override string InvalidSample => "TOOSHORT12";
}
