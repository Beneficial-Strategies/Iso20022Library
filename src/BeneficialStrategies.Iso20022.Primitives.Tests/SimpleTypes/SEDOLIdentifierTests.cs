// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class SEDOLIdentifierTests : SimpleValueStringContractTests<SEDOLIdentifier>
{
    // Real-world SEDOL: BP p.l.c. — https://www.isin.org/fix-sedol/ and multiple check-digit
    // calculators confirm 0798059 (core 079805, check digit 9).
    protected override string ValidSample => "0798059";
    protected override string InvalidSample => "0798050"; // same core, wrong check digit

    [Fact]
    public void KnownValue_BP_ChecksumIsCorrect()
    {
        var sedol = new SEDOLIdentifier("0798059");
        Assert.Equal("079805", sedol.Core);
        Assert.Equal('9', sedol.CheckDigit);
    }

    [Fact]
    public void KnownValue_Vodafone_LetterCoreChecksumIsCorrect()
    {
        // Real-world SEDOL with letters in the core: Vodafone Group plc = B16GWD5.
        var sedol = new SEDOLIdentifier("B16GWD5");
        Assert.Equal("B16GWD", sedol.Core);
        Assert.Equal('5', sedol.CheckDigit);
    }

    [Fact]
    public void CoreOnlyConstruction_GeneratesCheckDigit()
    {
        var sedol = new SEDOLIdentifier("079805");
        Assert.Equal("0798059", sedol.Value);
        Assert.Equal("079805", sedol.Core);
        Assert.Equal('9', sedol.CheckDigit);
    }

    [Fact]
    public void FullValue_WrongCheckDigit_ThrowsCheckDigitMismatch()
    {
        var ex = Assert.Throws<Iso20022FormatException>(() => new SEDOLIdentifier("0798051"));
        Assert.Equal(Iso20022FormatViolation.CheckDigitMismatch, ex.Violation);
    }

    [Fact]
    public void ComputeCheckDigit_MatchesKnownExamples()
    {
        Assert.Equal('9', SEDOLIdentifier.ComputeCheckDigit("079805"));
        Assert.Equal('5', SEDOLIdentifier.ComputeCheckDigit("B16GWD"));
    }

    [Fact]
    public void TryCreate_CoreOnly_Succeeds()
    {
        Assert.True(SEDOLIdentifier.TryCreate("079805", out var sedol));
        Assert.Equal("0798059", sedol.Value);
    }

    [Fact]
    public void TryCreate_WrongCheckDigit_ReturnsFalse()
    {
        Assert.False(SEDOLIdentifier.TryCreate("0798051", out _));
    }
}
