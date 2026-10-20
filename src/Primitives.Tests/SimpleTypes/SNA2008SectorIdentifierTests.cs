// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class SNA2008SectorIdentifierTests : SimpleValueStringContractTests<SNA2008SectorIdentifier>
{
    protected override string ValidSample => "S11";
    protected override string InvalidSample => "X11"; // must start with "S"

    [Theory]
    [InlineData("S1")]  // total economy
    [InlineData("S11")] // non-financial corporations
    [InlineData("S12")] // financial corporations
    [InlineData("S13")] // general government
    [InlineData("S14")] // households
    [InlineData("S15")] // NPISH
    [InlineData("S2")]  // rest of world
    public void TopLevelSectorCodes_Accepted(string code)
    {
        Assert.True(SNA2008SectorIdentifier.TryCreate(code, out _));
    }

    [Fact]
    public void MissingDigits_Rejected()
    {
        Assert.False(SNA2008SectorIdentifier.TryCreate("S", out _));
    }
}
