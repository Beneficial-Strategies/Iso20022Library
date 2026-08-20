// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ProxyAccountIdentification1ValidatorTests
{
    private readonly ProxyAccountIdentification1Validator _sut = new();

    private static ProxyAccountIdentification1 ValidMessage() => new() { Identification = "alias@example.com" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Type_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Type = new BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice.Proprietary
            {
                Value = "MYPROXYTYPE",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
