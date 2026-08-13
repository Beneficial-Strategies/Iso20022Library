// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdLanguageTests : SimpleValueStringContractTests<XsdLanguage>
{
    protected override string ValidSample => "en-US";
    protected override string InvalidSample => "123";
}
