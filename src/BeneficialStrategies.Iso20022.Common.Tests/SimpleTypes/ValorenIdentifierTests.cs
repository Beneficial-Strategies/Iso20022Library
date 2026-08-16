// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ValorenIdentifierTests : SimpleValueStringContractTests<ValorenIdentifier>
{
    protected override string ValidSample => "1213853";
    protected override string InvalidSample => "12345"; // only 5 digits, below the 6-digit minimum

    [Fact]
    public void TenDigits_TooLong_Rejected()
    {
        Assert.False(ValorenIdentifier.TryCreate("1234567890", out _));
    }

    [Fact]
    public void Letters_Rejected()
    {
        // Valoren numbers are digits-only, per source cited in the type's remarks.
        Assert.False(ValorenIdentifier.TryCreate("ABC1234", out _));
    }
}
