// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalAuthenticationMethod1CodeTests : ExternalCodesetContractTests<ExternalAuthenticationMethod1Code>
{
    protected override string ValidSample => "PSWD";
    protected override string InvalidSample => "TOOLONG";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_Password_HasExpectedWireCode()
    {
        Assert.Equal("PSWD", ExternalAuthenticationMethod1Code.Password.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalAuthenticationMethod1Code("PSWD"), ExternalAuthenticationMethod1Code.Password);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // "ZZZZ" is not one of the 68 known registry values above, but it still satisfies the
        // open Pattern constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalAuthenticationMethod1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
