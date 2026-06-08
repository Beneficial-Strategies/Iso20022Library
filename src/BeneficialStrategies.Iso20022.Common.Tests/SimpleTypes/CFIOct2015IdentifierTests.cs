// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class CFIOct2015IdentifierTests : SimpleValueStringContractTests<CFIOct2015Identifier>
{
    protected override string ValidSample   => "ESXXXX";
    protected override string InvalidSample => "ESXXX";
}
