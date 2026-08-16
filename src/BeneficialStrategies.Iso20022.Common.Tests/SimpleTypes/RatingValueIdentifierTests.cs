// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RatingValueIdentifierTests : SimpleValueStringContractTests<RatingValueIdentifier>
{
    protected override string ValidSample => "AAA";
    protected override string InvalidSample => "aaa"; // lowercase-leading violates the shared casing convention

    [Theory]
    [InlineData("AAA")]
    [InlineData("AA+")]
    [InlineData("BBB-")]
    [InlineData("D")]
    [InlineData("NR")]
    [InlineData("SD")]
    [InlineData("RD")]
    public void StandardAndPoorsFitchStyleGrades_Accepted(string grade)
    {
        Assert.True(RatingValueIdentifier.TryCreate(grade, out _));
    }

    [Theory]
    [InlineData("Aaa")]
    [InlineData("Aa1")]
    [InlineData("Baa2")]
    [InlineData("Ba3")]
    [InlineData("Caa1")]
    [InlineData("Ca")]
    public void MoodysStyleGrades_Accepted(string grade)
    {
        Assert.True(RatingValueIdentifier.TryCreate(grade, out _));
    }

    [Theory]
    [InlineData("aaa")] // lowercase leading letter
    [InlineData("1AA")] // leading digit
    [InlineData("")]    // empty
    public void NonConformingCasing_Rejected(string value)
    {
        Assert.False(RatingValueIdentifier.TryCreate(value, out _));
    }
}
