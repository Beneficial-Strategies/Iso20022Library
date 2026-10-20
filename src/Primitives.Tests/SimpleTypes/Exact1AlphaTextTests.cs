// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact1AlphaTextTests : SimpleValueMaxTextContractTests<Exact1AlphaText>
{
    protected override int MinLength => 1;
    protected override int MaxLength => 1;
    protected override string ValidSample => "A";
    protected override string InvalidSample => "12"; // digit + wrong length

    [Fact]
    public void Digit_ThrowsInvalidCharacter()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(Exact1AlphaText), "1"));
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }
}
