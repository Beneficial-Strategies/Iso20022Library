// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class IBAN2007IdentifierTests : SimpleValueStringContractTests<IBAN2007Identifier>
{
    protected override string ValidSample   => "GB29NWBK60161331926819";
    protected override string InvalidSample => "INVALID";
}
