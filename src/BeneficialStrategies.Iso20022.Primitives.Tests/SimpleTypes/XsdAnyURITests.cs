// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdAnyURITests : SimpleValueStringContractTests<XsdAnyURI>
{
    protected override string ValidSample => "https://example.com/path?query=1";
    // Uri.TryCreate(RelativeOrAbsolute) accepts nearly any string as a valid *relative*
    // reference (even "<>" or whitespace) — only a malformed *absolute* form (scheme + broken
    // authority) reliably fails, so the sample needs an explicit scheme.
    protected override string InvalidSample => "http://exa mple.com";
}
