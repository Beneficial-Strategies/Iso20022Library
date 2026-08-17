// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalNotificationTypeCodeTests : ExternalCodesetContractTests<ExternalNotificationTypeCode>
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
        Assert.Equal("ADDR", ExternalNotificationTypeCode.ChangeOfAddress.Value);
    }

    [Fact]
    public void KnownValue_AccountTermsAndConditions_HasExpectedWireCode()
    {
        Assert.Equal("ATAC", ExternalNotificationTypeCode.AccountTermsAndConditions.Value);
    }

    [Fact]
    public void KnownValue_ContactDetailsUpdate_HasExpectedWireCode()
    {
        Assert.Equal("COUP", ExternalNotificationTypeCode.ContactDetailsUpdate.Value);
    }

    [Fact]
    public void KnownValue_CurrencyHoliday_HasExpectedWireCode()
    {
        Assert.Equal("CUHO", ExternalNotificationTypeCode.CurrencyHoliday.Value);
    }

    [Fact]
    public void KnownValue_IndustryChanges_HasExpectedWireCode()
    {
        Assert.Equal("INCH", ExternalNotificationTypeCode.IndustryChanges.Value);
    }

    [Fact]
    public void KnownValue_InformationSharing_HasExpectedWireCode()
    {
        Assert.Equal("INFO", ExternalNotificationTypeCode.InformationSharing.Value);
    }

    [Fact]
    public void KnownValue_AdviceOfAMerger_HasExpectedWireCode()
    {
        Assert.Equal("MERG", ExternalNotificationTypeCode.AdviceOfAMerger.Value);
    }

    [Fact]
    public void KnownValue_ChangeOfBankBranchOpeningHours_HasExpectedWireCode()
    {
        Assert.Equal("OPEN", ExternalNotificationTypeCode.ChangeOfBankBranchOpeningHours.Value);
    }

    [Fact]
    public void KnownValue_Other_HasExpectedWireCode()
    {
        Assert.Equal("OTHR", ExternalNotificationTypeCode.Other.Value);
    }

    [Fact]
    public void KnownValue_StandingSettlementInstructionsUpdate_HasExpectedWireCode()
    {
        Assert.Equal("SSIS", ExternalNotificationTypeCode.StandingSettlementInstructionsUpdate.Value);
    }

    [Fact]
    public void KnownValue_Suspension_HasExpectedWireCode()
    {
        Assert.Equal("SUSP", ExternalNotificationTypeCode.Suspension.Value);
    }

    [Fact]
    public void KnownValue_SystemAccessRequest_HasExpectedWireCode()
    {
        Assert.Equal("SYST", ExternalNotificationTypeCode.SystemAccessRequest.Value);
    }

    [Fact]
    public void KnownValue_ServiceTermination_HasExpectedWireCode()
    {
        Assert.Equal("TERM", ExternalNotificationTypeCode.ServiceTermination.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalNotificationTypeCode("ADDR"), ExternalNotificationTypeCode.ChangeOfAddress);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalNotificationTypeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
