// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdTokenTests : SimpleValueStringContractTests<XsdToken>
{
    protected override string ValidSample => "hello world";
    protected override string InvalidSample => "hello  world"; // internal double space
}
