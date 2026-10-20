// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalAccountVerificationReason1CodeTests : ExternalCodesetContractTests<ExternalAccountVerificationReason1Code>
{
    protected override string ValidSample => "RC01";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_UnsupportedPartyIdentification_HasExpectedWireCode()
    {
        Assert.Equal("RC01", ExternalAccountVerificationReason1Code.UnsupportedPartyIdentification.Value);
    }

    [Fact]
    public void KnownValue_MissingPartyIdentification_HasExpectedWireCode()
    {
        Assert.Equal("RC02", ExternalAccountVerificationReason1Code.MissingPartyIdentification.Value);
    }

    [Fact]
    public void KnownValue_MissingPartyName_HasExpectedWireCode()
    {
        Assert.Equal("RC03", ExternalAccountVerificationReason1Code.MissingPartyName.Value);
    }

    [Fact]
    public void KnownValue_NameMatchingEngineLimitation_HasExpectedWireCode()
    {
        Assert.Equal("RC04", ExternalAccountVerificationReason1Code.NameMatchingEngineLimitation.Value);
    }

    [Fact]
    public void KnownValue_UnsupportedAccountFormat_HasExpectedWireCode()
    {
        Assert.Equal("RC05", ExternalAccountVerificationReason1Code.UnsupportedAccountFormat.Value);
    }

    [Fact]
    public void KnownValue_InvalidAccountType_HasExpectedWireCode()
    {
        Assert.Equal("RC06", ExternalAccountVerificationReason1Code.InvalidAccountType.Value);
    }

    [Fact]
    public void KnownValue_UnsupportedAccount_HasExpectedWireCode()
    {
        Assert.Equal("RC07", ExternalAccountVerificationReason1Code.UnsupportedAccount.Value);
    }

    [Fact]
    public void KnownValue_IncorrectAccountNumber_HasExpectedWireCode()
    {
        Assert.Equal("RC08", ExternalAccountVerificationReason1Code.IncorrectAccountNumber.Value);
    }

    [Fact]
    public void KnownValue_ClosedAccountNumber_HasExpectedWireCode()
    {
        Assert.Equal("RC09", ExternalAccountVerificationReason1Code.ClosedAccountNumber.Value);
    }

    [Fact]
    public void KnownValue_BlockedAccount_HasExpectedWireCode()
    {
        Assert.Equal("RC10", ExternalAccountVerificationReason1Code.BlockedAccount.Value);
    }

    [Fact]
    public void KnownValue_FraudulentAccount_HasExpectedWireCode()
    {
        Assert.Equal("RC11", ExternalAccountVerificationReason1Code.FraudulentAccount.Value);
    }

    [Fact]
    public void KnownValue_MismatchAccountPartyAgent_HasExpectedWireCode()
    {
        Assert.Equal("RC12", ExternalAccountVerificationReason1Code.MismatchAccountPartyAgent.Value);
    }

    [Fact]
    public void KnownValue_PartyAgentNotRegistered_HasExpectedWireCode()
    {
        Assert.Equal("RC13", ExternalAccountVerificationReason1Code.PartyAgentNotRegistered.Value);
    }

    [Fact]
    public void KnownValue_PartyAgentNotValid_HasExpectedWireCode()
    {
        Assert.Equal("RC14", ExternalAccountVerificationReason1Code.PartyAgentNotValid.Value);
    }

    [Fact]
    public void KnownValue_UnsupportedRequestorScope_HasExpectedWireCode()
    {
        Assert.Equal("RC15", ExternalAccountVerificationReason1Code.UnsupportedRequestorScope.Value);
    }

    [Fact]
    public void KnownValue_RequestorBankNotRegistered_HasExpectedWireCode()
    {
        Assert.Equal("RC16", ExternalAccountVerificationReason1Code.RequestorBankNotRegistered.Value);
    }

    [Fact]
    public void KnownValue_SchemeResponse_HasExpectedWireCode()
    {
        Assert.Equal("RC17", ExternalAccountVerificationReason1Code.SchemeResponse.Value);
    }

    [Fact]
    public void KnownValue_SchemeResponseUnvailablePartyAgent_HasExpectedWireCode()
    {
        Assert.Equal("RC18", ExternalAccountVerificationReason1Code.SchemeResponseUnvailablePartyAgent.Value);
    }

    [Fact]
    public void KnownValue_SchemeResponseInvalidRequest_HasExpectedWireCode()
    {
        Assert.Equal("RC19", ExternalAccountVerificationReason1Code.SchemeResponseInvalidRequest.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalAccountVerificationReason1Code("RC01"), ExternalAccountVerificationReason1Code.UnsupportedPartyIdentification);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalAccountVerificationReason1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
