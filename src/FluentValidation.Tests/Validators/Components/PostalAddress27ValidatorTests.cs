// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PostalAddress27ValidatorTests
{
    private readonly PostalAddress27Validator _sut = new();

    private static PostalAddress27 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AddressType_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            AddressType = new BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Code
            {
                Value = AddressType2Code.Business,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
