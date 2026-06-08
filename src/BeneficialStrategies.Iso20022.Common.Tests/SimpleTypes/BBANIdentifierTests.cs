// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class BBANIdentifierTests : SimpleValueStringContractTests<BBANIdentifier>
{
    protected override string ValidSample => "NWBK60161331926819";
    protected override string InvalidSample => "NWBK-INVALID";
}
