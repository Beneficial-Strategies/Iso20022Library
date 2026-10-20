// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class LEIIdentifierTests : SimpleValueStringContractTests<LEIIdentifier>
{
    protected override string ValidSample => "HWUPKR0MPOU8FGXBT394";
    protected override string InvalidSample => "TOOSHORT";
}
