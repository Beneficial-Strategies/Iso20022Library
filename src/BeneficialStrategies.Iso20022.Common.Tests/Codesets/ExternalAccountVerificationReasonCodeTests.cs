// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalAccountVerificationReasonCodeTests : ExternalCodesetContractTests<ExternalAccountVerificationReasonCode>
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
        Assert.Equal("RC01", ExternalAccountVerificationReasonCode.UnsupportedPartyIdentification.Value);
    }

    [Fact]
    public void KnownValue_MissingPartyIdentification_HasExpectedWireCode()
    {
        Assert.Equal("RC02", ExternalAccountVerificationReasonCode.MissingPartyIdentification.Value);
    }

    [Fact]
    public void KnownValue_MissingPartyName_HasExpectedWireCode()
    {
        Assert.Equal("RC03", ExternalAccountVerificationReasonCode.MissingPartyName.Value);
    }

    [Fact]
    public void KnownValue_NameMatchingEngineLimitation_HasExpectedWireCode()
    {
        Assert.Equal("RC04", ExternalAccountVerificationReasonCode.NameMatchingEngineLimitation.Value);
    }

    [Fact]
    public void KnownValue_UnsupportedAccountFormat_HasExpectedWireCode()
    {
        Assert.Equal("RC05", ExternalAccountVerificationReasonCode.UnsupportedAccountFormat.Value);
    }

    [Fact]
    public void KnownValue_InvalidAccountType_HasExpectedWireCode()
    {
        Assert.Equal("RC06", ExternalAccountVerificationReasonCode.InvalidAccountType.Value);
    }

    [Fact]
    public void KnownValue_UnsupportedAccount_HasExpectedWireCode()
    {
        Assert.Equal("RC07", ExternalAccountVerificationReasonCode.UnsupportedAccount.Value);
    }

    [Fact]
    public void KnownValue_IncorrectAccountNumber_HasExpectedWireCode()
    {
        Assert.Equal("RC08", ExternalAccountVerificationReasonCode.IncorrectAccountNumber.Value);
    }

    [Fact]
    public void KnownValue_ClosedAccountNumber_HasExpectedWireCode()
    {
        Assert.Equal("RC09", ExternalAccountVerificationReasonCode.ClosedAccountNumber.Value);
    }

    [Fact]
    public void KnownValue_BlockedAccount_HasExpectedWireCode()
    {
        Assert.Equal("RC10", ExternalAccountVerificationReasonCode.BlockedAccount.Value);
    }

    [Fact]
    public void KnownValue_FraudulentAccount_HasExpectedWireCode()
    {
        Assert.Equal("RC11", ExternalAccountVerificationReasonCode.FraudulentAccount.Value);
    }

    [Fact]
    public void KnownValue_MismatchAccountPartyAgent_HasExpectedWireCode()
    {
        Assert.Equal("RC12", ExternalAccountVerificationReasonCode.MismatchAccountPartyAgent.Value);
    }

    [Fact]
    public void KnownValue_PartyAgentNotRegistered_HasExpectedWireCode()
    {
        Assert.Equal("RC13", ExternalAccountVerificationReasonCode.PartyAgentNotRegistered.Value);
    }

    [Fact]
    public void KnownValue_PartyAgentNotValid_HasExpectedWireCode()
    {
        Assert.Equal("RC14", ExternalAccountVerificationReasonCode.PartyAgentNotValid.Value);
    }

    [Fact]
    public void KnownValue_UnsupportedRequestorScope_HasExpectedWireCode()
    {
        Assert.Equal("RC15", ExternalAccountVerificationReasonCode.UnsupportedRequestorScope.Value);
    }

    [Fact]
    public void KnownValue_RequestorBankNotRegistered_HasExpectedWireCode()
    {
        Assert.Equal("RC16", ExternalAccountVerificationReasonCode.RequestorBankNotRegistered.Value);
    }

    [Fact]
    public void KnownValue_SchemeResponse_HasExpectedWireCode()
    {
        Assert.Equal("RC17", ExternalAccountVerificationReasonCode.SchemeResponse.Value);
    }

    [Fact]
    public void KnownValue_SchemeResponseUnvailablePartyAgent_HasExpectedWireCode()
    {
        Assert.Equal("RC18", ExternalAccountVerificationReasonCode.SchemeResponseUnvailablePartyAgent.Value);
    }

    [Fact]
    public void KnownValue_SchemeResponseInvalidRequest_HasExpectedWireCode()
    {
        Assert.Equal("RC19", ExternalAccountVerificationReasonCode.SchemeResponseInvalidRequest.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalAccountVerificationReasonCode("RC01"), ExternalAccountVerificationReasonCode.UnsupportedPartyIdentification);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalAccountVerificationReasonCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
