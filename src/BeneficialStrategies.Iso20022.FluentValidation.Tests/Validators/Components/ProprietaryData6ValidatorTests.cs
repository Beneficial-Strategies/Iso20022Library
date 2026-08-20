// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ProprietaryData6ValidatorTests
{
    private readonly ProprietaryData6Validator _sut = new();

    private static ProprietaryData6 ValidMessage() => new() { Any = new ExternalSchema.SkipPayload() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
