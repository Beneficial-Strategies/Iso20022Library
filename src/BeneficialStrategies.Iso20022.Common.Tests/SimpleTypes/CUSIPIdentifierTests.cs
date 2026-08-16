// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class CUSIPIdentifierTests : SimpleValueStringContractTests<CUSIPIdentifier>
{
    // Real-world CUSIP: Apple Inc. — https://rosettacode.org/wiki/CUSIP and multiple check-digit
    // calculators confirm 037833100 (core 03783310, check digit 0).
    protected override string ValidSample => "037833100";
    protected override string InvalidSample => "037833101"; // same core, wrong check digit

    [Fact]
    public void KnownValue_Apple_ChecksumIsCorrect()
    {
        var cusip = new CUSIPIdentifier("037833100");
        Assert.Equal("03783310", cusip.Core);
        Assert.Equal('0', cusip.CheckDigit);
    }

    [Fact]
    public void KnownValue_BerkshireHathawayB_ChecksumIsCorrect()
    {
        var cusip = new CUSIPIdentifier("084670207");
        Assert.Equal("08467020", cusip.Core);
        Assert.Equal('7', cusip.CheckDigit);
    }

    [Fact]
    public void CoreOnlyConstruction_GeneratesCheckDigit()
    {
        var cusip = new CUSIPIdentifier("03783310");
        Assert.Equal("037833100", cusip.Value);
        Assert.Equal("03783310", cusip.Core);
        Assert.Equal('0', cusip.CheckDigit);
    }

    [Fact]
    public void FullValue_WrongCheckDigit_ThrowsCheckDigitMismatch()
    {
        var ex = Assert.Throws<Iso20022FormatException>(() => new CUSIPIdentifier("037833101"));
        Assert.Equal(Iso20022FormatViolation.CheckDigitMismatch, ex.Violation);
    }

    [Fact]
    public void ComputeCheckDigit_MatchesKnownExamples()
    {
        Assert.Equal('0', CUSIPIdentifier.ComputeCheckDigit("03783310"));
        Assert.Equal('7', CUSIPIdentifier.ComputeCheckDigit("08467020"));
    }

    [Fact]
    public void TryCreate_CoreOnly_Succeeds()
    {
        Assert.True(CUSIPIdentifier.TryCreate("03783310", out var cusip));
        Assert.Equal("037833100", cusip.Value);
    }

    [Fact]
    public void TryCreate_WrongCheckDigit_ReturnsFalse()
    {
        Assert.False(CUSIPIdentifier.TryCreate("037833101", out _));
    }
}
