// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BranchData5ValidatorTests
{
    private readonly BranchData5Validator _sut = new();

    private static BranchData5 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PostalAddress_Present_NoValidationError()
    {
        var msg = ValidMessage() with { PostalAddress = new PostalAddress27 { TownName = "Springfield" } };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
