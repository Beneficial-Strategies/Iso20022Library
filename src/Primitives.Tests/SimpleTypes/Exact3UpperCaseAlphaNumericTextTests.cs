// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact3UpperCaseAlphaNumericTextTests : SimpleValueMaxTextContractTests<Exact3UpperCaseAlphaNumericText>
{
    protected override int MinLength => 3;
    protected override int MaxLength => 3;
    protected override string ValidSample => "A1B";
    protected override string InvalidSample => "abcd"; // lowercase + wrong length

    [Fact]
    public void LowerCase_ThrowsInvalidCharacter()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(Exact3UpperCaseAlphaNumericText), "abc"));
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }
}
