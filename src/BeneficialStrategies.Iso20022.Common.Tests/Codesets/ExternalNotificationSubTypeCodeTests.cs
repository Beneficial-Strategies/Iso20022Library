// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalNotificationSubTypeCodeTests : ExternalCodesetContractTests<ExternalNotificationSubTypeCode>
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
        Assert.Equal("CRED", ExternalNotificationSubTypeCode.Credit.Value);
    }

    [Fact]
    public void KnownValue_Liquidity_HasExpectedWireCode()
    {
        Assert.Equal("LIQI", ExternalNotificationSubTypeCode.Liquidity.Value);
    }

    [Fact]
    public void KnownValue_Loans_HasExpectedWireCode()
    {
        Assert.Equal("LOAN", ExternalNotificationSubTypeCode.Loans.Value);
    }

    [Fact]
    public void KnownValue_PaymentOperations_HasExpectedWireCode()
    {
        Assert.Equal("PAOP", ExternalNotificationSubTypeCode.PaymentOperations.Value);
    }

    [Fact]
    public void KnownValue_Sales_HasExpectedWireCode()
    {
        Assert.Equal("SALE", ExternalNotificationSubTypeCode.Sales.Value);
    }

    [Fact]
    public void KnownValue_Servicing_HasExpectedWireCode()
    {
        Assert.Equal("SERV", ExternalNotificationSubTypeCode.Servicing.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalNotificationSubTypeCode("CRED"), ExternalNotificationSubTypeCode.Credit);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalNotificationSubTypeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
