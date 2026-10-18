// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalNotificationType1CodeTests : ExternalCodesetContractTests<ExternalNotificationType1Code>
{
    protected override string ValidSample => "ADDR";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_ChangeOfAddress_HasExpectedWireCode()
    {
        Assert.Equal("ADDR", ExternalNotificationType1Code.ChangeOfAddress.Value);
    }

    [Fact]
    public void KnownValue_AccountTermsAndConditions_HasExpectedWireCode()
    {
        Assert.Equal("ATAC", ExternalNotificationType1Code.AccountTermsAndConditions.Value);
    }

    [Fact]
    public void KnownValue_ContactDetailsUpdate_HasExpectedWireCode()
    {
        Assert.Equal("COUP", ExternalNotificationType1Code.ContactDetailsUpdate.Value);
    }

    [Fact]
    public void KnownValue_CurrencyHoliday_HasExpectedWireCode()
    {
        Assert.Equal("CUHO", ExternalNotificationType1Code.CurrencyHoliday.Value);
    }

    [Fact]
    public void KnownValue_IndustryChanges_HasExpectedWireCode()
    {
        Assert.Equal("INCH", ExternalNotificationType1Code.IndustryChanges.Value);
    }

    [Fact]
    public void KnownValue_InformationSharing_HasExpectedWireCode()
    {
        Assert.Equal("INFO", ExternalNotificationType1Code.InformationSharing.Value);
    }

    [Fact]
    public void KnownValue_AdviceOfAMerger_HasExpectedWireCode()
    {
        Assert.Equal("MERG", ExternalNotificationType1Code.AdviceOfAMerger.Value);
    }

    [Fact]
    public void KnownValue_ChangeOfBankBranchOpeningHours_HasExpectedWireCode()
    {
        Assert.Equal("OPEN", ExternalNotificationType1Code.ChangeOfBankBranchOpeningHours.Value);
    }

    [Fact]
    public void KnownValue_Other_HasExpectedWireCode()
    {
        Assert.Equal("OTHR", ExternalNotificationType1Code.Other.Value);
    }

    [Fact]
    public void KnownValue_StandingSettlementInstructionsUpdate_HasExpectedWireCode()
    {
        Assert.Equal("SSIS", ExternalNotificationType1Code.StandingSettlementInstructionsUpdate.Value);
    }

    [Fact]
    public void KnownValue_Suspension_HasExpectedWireCode()
    {
        Assert.Equal("SUSP", ExternalNotificationType1Code.Suspension.Value);
    }

    [Fact]
    public void KnownValue_SystemAccessRequest_HasExpectedWireCode()
    {
        Assert.Equal("SYST", ExternalNotificationType1Code.SystemAccessRequest.Value);
    }

    [Fact]
    public void KnownValue_ServiceTermination_HasExpectedWireCode()
    {
        Assert.Equal("TERM", ExternalNotificationType1Code.ServiceTermination.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalNotificationType1Code("ADDR"), ExternalNotificationType1Code.ChangeOfAddress);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalNotificationType1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
