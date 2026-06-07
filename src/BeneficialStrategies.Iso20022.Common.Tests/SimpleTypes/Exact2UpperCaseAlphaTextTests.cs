// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact2UpperCaseAlphaTextTests : SimpleValueMaxTextContractTests<Exact2UpperCaseAlphaText>
{
    protected override int MinLength => 2;
    protected override int MaxLength => 2;
    protected override string ValidSample   => "AB";
    protected override string InvalidSample => "123"; // digits, not alpha; wrong length too

    [Fact]
    public void Digit_ThrowsInvalidCharacter()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(Exact2UpperCaseAlphaText), "1A"));
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }

    [Fact]
    public void LowerCase_ThrowsInvalidCharacter()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(Exact2UpperCaseAlphaText), "ab"));
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }
}
