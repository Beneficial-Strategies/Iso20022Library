// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalDecisionStatusUpdateReason1CodeTests : ExternalCodesetContractTests<ExternalDecisionStatusUpdateReason1Code>
{
    protected override string ValidSample => "AAUT";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_AuthorisationUnderArt34_HasExpectedWireCode()
    {
        Assert.Equal("AAUT", ExternalDecisionStatusUpdateReason1Code.AuthorisationUnderArt34.Value);
    }

    [Fact]
    public void KnownValue_EndorsementUnderArt33_HasExpectedWireCode()
    {
        Assert.Equal("ADRS", ExternalDecisionStatusUpdateReason1Code.EndorsementUnderArt33.Value);
    }

    [Fact]
    public void KnownValue_EquivalenceUnderArt30_HasExpectedWireCode()
    {
        Assert.Equal("AEQA", ExternalDecisionStatusUpdateReason1Code.EquivalenceUnderArt30.Value);
    }

    [Fact]
    public void KnownValue_RecognitionUnderArt32_HasExpectedWireCode()
    {
        Assert.Equal("ARCG", ExternalDecisionStatusUpdateReason1Code.RecognitionUnderArt32.Value);
    }

    [Fact]
    public void KnownValue_RegistrationUnderrt34_HasExpectedWireCode()
    {
        Assert.Equal("AREG", ExternalDecisionStatusUpdateReason1Code.RegistrationUnderrt34.Value);
    }

    [Fact]
    public void KnownValue_CessationOfEndorsementUnderArt33_HasExpectedWireCode()
    {
        Assert.Equal("CDRS", ExternalDecisionStatusUpdateReason1Code.CessationOfEndorsementUnderArt33.Value);
    }

    [Fact]
    public void KnownValue_NonCompliantUnderArt24_HasExpectedWireCode()
    {
        Assert.Equal("NCOM", ExternalDecisionStatusUpdateReason1Code.NonCompliantUnderArt24.Value);
    }

    [Fact]
    public void KnownValue_NotYetLicensedUnderArt24_HasExpectedWireCode()
    {
        Assert.Equal("NLIC", ExternalDecisionStatusUpdateReason1Code.NotYetLicensedUnderArt24.Value);
    }

    [Fact]
    public void KnownValue_SuspensionOfAuthorisationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("SAUT", ExternalDecisionStatusUpdateReason1Code.SuspensionOfAuthorisationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_SuspensionOfRecognitionUnderArt32_HasExpectedWireCode()
    {
        Assert.Equal("SRCG", ExternalDecisionStatusUpdateReason1Code.SuspensionOfRecognitionUnderArt32.Value);
    }

    [Fact]
    public void KnownValue_SuspensionOfRegistrationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("SREG", ExternalDecisionStatusUpdateReason1Code.SuspensionOfRegistrationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfAuthorisationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("WAUT", ExternalDecisionStatusUpdateReason1Code.WithdrawalOfAuthorisationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalByThirdCountryCompetentAuthorityUnderArt30_HasExpectedWireCode()
    {
        Assert.Equal("WEQA", ExternalDecisionStatusUpdateReason1Code.WithdrawalByThirdCountryCompetentAuthorityUnderArt30.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfTheThirdCountryAdministratorUnderArt31_HasExpectedWireCode()
    {
        Assert.Equal("WEQE", ExternalDecisionStatusUpdateReason1Code.WithdrawalOfTheThirdCountryAdministratorUnderArt31.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfRecognitionUnderArt32_HasExpectedWireCode()
    {
        Assert.Equal("WRCG", ExternalDecisionStatusUpdateReason1Code.WithdrawalOfRecognitionUnderArt32.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfRegistrationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("WREG", ExternalDecisionStatusUpdateReason1Code.WithdrawalOfRegistrationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalDecisionStatusUpdateReason1Code("AAUT"), ExternalDecisionStatusUpdateReason1Code.AuthorisationUnderArt34);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalDecisionStatusUpdateReason1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
