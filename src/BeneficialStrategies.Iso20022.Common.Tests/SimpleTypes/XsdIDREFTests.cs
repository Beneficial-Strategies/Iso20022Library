// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdIDREFTests : SimpleValueStringContractTests<XsdIDREF>
{
    protected override string ValidSample => "id-1";
    protected override string InvalidSample => "1-id"; // must not start with a digit
}
