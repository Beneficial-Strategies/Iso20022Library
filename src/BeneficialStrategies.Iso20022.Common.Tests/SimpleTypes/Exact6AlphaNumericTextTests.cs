// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact6AlphaNumericTextTests : SimpleValueMaxTextContractTests<Exact6AlphaNumericText>
{
    protected override int MinLength => 6;
    protected override int MaxLength => 6;
    protected override string ValidSample   => "AB1 CD"; // alphanumeric + space (whitespace is allowed)
    protected override string InvalidSample => "AB1CD!!"; // special chars + wrong length

    [Fact]
    public void SpecialChar_ThrowsInvalidCharacter()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(Exact6AlphaNumericText), "!!!!!!"));
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }

    [Fact]
    public void Whitespace_IsAccepted()
    {
        var instance = Activator.CreateInstance(typeof(Exact6AlphaNumericText), "AB  CD");
        Assert.NotNull(instance);
    }
}
