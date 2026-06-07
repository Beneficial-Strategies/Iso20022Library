// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact4AlphaNumericUnderscoreTextTests : SimpleValueMaxTextContractTests<Exact4AlphaNumericUnderscoreText>
{
    protected override int MinLength => 4;
    protected override int MaxLength => 4;
    protected override string ValidSample   => "A_1b";
    protected override string InvalidSample => "ABCDE"; // too long

    [Fact]
    public void LeadingUnderscore_ThrowsInvalidCharacter()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(Exact4AlphaNumericUnderscoreText), "_ABC"));
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }

    [Fact]
    public void TrailingUnderscore_IsAccepted()
    {
        var instance = Activator.CreateInstance(typeof(Exact4AlphaNumericUnderscoreText), "ABC_");
        Assert.NotNull(instance);
    }
}
