// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalDecisionStatusUpdateReasonCodeTests : ExternalCodesetContractTests<ExternalDecisionStatusUpdateReasonCode>
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
        Assert.Equal("AAUT", ExternalDecisionStatusUpdateReasonCode.AuthorisationUnderArt34.Value);
    }

    [Fact]
    public void KnownValue_EndorsementUnderArt33_HasExpectedWireCode()
    {
        Assert.Equal("ADRS", ExternalDecisionStatusUpdateReasonCode.EndorsementUnderArt33.Value);
    }

    [Fact]
    public void KnownValue_EquivalenceUnderArt30_HasExpectedWireCode()
    {
        Assert.Equal("AEQA", ExternalDecisionStatusUpdateReasonCode.EquivalenceUnderArt30.Value);
    }

    [Fact]
    public void KnownValue_RecognitionUnderArt32_HasExpectedWireCode()
    {
        Assert.Equal("ARCG", ExternalDecisionStatusUpdateReasonCode.RecognitionUnderArt32.Value);
    }

    [Fact]
    public void KnownValue_RegistrationUnderrt34_HasExpectedWireCode()
    {
        Assert.Equal("AREG", ExternalDecisionStatusUpdateReasonCode.RegistrationUnderrt34.Value);
    }

    [Fact]
    public void KnownValue_CessationOfEndorsementUnderArt33_HasExpectedWireCode()
    {
        Assert.Equal("CDRS", ExternalDecisionStatusUpdateReasonCode.CessationOfEndorsementUnderArt33.Value);
    }

    [Fact]
    public void KnownValue_NonCompliantUnderArt24_HasExpectedWireCode()
    {
        Assert.Equal("NCOM", ExternalDecisionStatusUpdateReasonCode.NonCompliantUnderArt24.Value);
    }

    [Fact]
    public void KnownValue_NotYetLicensedUnderArt24_HasExpectedWireCode()
    {
        Assert.Equal("NLIC", ExternalDecisionStatusUpdateReasonCode.NotYetLicensedUnderArt24.Value);
    }

    [Fact]
    public void KnownValue_SuspensionOfAuthorisationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("SAUT", ExternalDecisionStatusUpdateReasonCode.SuspensionOfAuthorisationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_SuspensionOfRecognitionUnderArt32_HasExpectedWireCode()
    {
        Assert.Equal("SRCG", ExternalDecisionStatusUpdateReasonCode.SuspensionOfRecognitionUnderArt32.Value);
    }

    [Fact]
    public void KnownValue_SuspensionOfRegistrationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("SREG", ExternalDecisionStatusUpdateReasonCode.SuspensionOfRegistrationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfAuthorisationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("WAUT", ExternalDecisionStatusUpdateReasonCode.WithdrawalOfAuthorisationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalByThirdCountryCompetentAuthorityUnderArt30_HasExpectedWireCode()
    {
        Assert.Equal("WEQA", ExternalDecisionStatusUpdateReasonCode.WithdrawalByThirdCountryCompetentAuthorityUnderArt30.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfTheThirdCountryAdministratorUnderArt31_HasExpectedWireCode()
    {
        Assert.Equal("WEQE", ExternalDecisionStatusUpdateReasonCode.WithdrawalOfTheThirdCountryAdministratorUnderArt31.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfRecognitionUnderArt32_HasExpectedWireCode()
    {
        Assert.Equal("WRCG", ExternalDecisionStatusUpdateReasonCode.WithdrawalOfRecognitionUnderArt32.Value);
    }

    [Fact]
    public void KnownValue_WithdrawalOfRegistrationUnderArt35_HasExpectedWireCode()
    {
        Assert.Equal("WREG", ExternalDecisionStatusUpdateReasonCode.WithdrawalOfRegistrationUnderArt35.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalDecisionStatusUpdateReasonCode("AAUT"), ExternalDecisionStatusUpdateReasonCode.AuthorisationUnderArt34);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalDecisionStatusUpdateReasonCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
