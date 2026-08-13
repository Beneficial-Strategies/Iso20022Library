// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNormalizedStringTests : SimpleValueStringContractTests<XsdNormalizedString>
{
    protected override string ValidSample => "  hello   world  "; // leading/trailing/internal runs OK
    protected override string InvalidSample => "hello\tworld";
}
