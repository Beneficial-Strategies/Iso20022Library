// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalNotificationSubType1CodeTests : ExternalCodesetContractTests<ExternalNotificationSubType1Code>
{
    protected override string ValidSample => "CRED";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_Credit_HasExpectedWireCode()
    {
        Assert.Equal("CRED", ExternalNotificationSubType1Code.Credit.Value);
    }

    [Fact]
    public void KnownValue_Liquidity_HasExpectedWireCode()
    {
        Assert.Equal("LIQI", ExternalNotificationSubType1Code.Liquidity.Value);
    }

    [Fact]
    public void KnownValue_Loans_HasExpectedWireCode()
    {
        Assert.Equal("LOAN", ExternalNotificationSubType1Code.Loans.Value);
    }

    [Fact]
    public void KnownValue_PaymentOperations_HasExpectedWireCode()
    {
        Assert.Equal("PAOP", ExternalNotificationSubType1Code.PaymentOperations.Value);
    }

    [Fact]
    public void KnownValue_Sales_HasExpectedWireCode()
    {
        Assert.Equal("SALE", ExternalNotificationSubType1Code.Sales.Value);
    }

    [Fact]
    public void KnownValue_Servicing_HasExpectedWireCode()
    {
        Assert.Equal("SERV", ExternalNotificationSubType1Code.Servicing.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalNotificationSubType1Code("CRED"), ExternalNotificationSubType1Code.Credit);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalNotificationSubType1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
