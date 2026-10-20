// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class NameAndAddress18ValidatorTests
{
    private readonly NameAndAddress18Validator _sut = new();

    private static NameAndAddress18 ValidMessage() =>
        new() { Name = "Jane Doe", Address = new PostalAddress27() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
