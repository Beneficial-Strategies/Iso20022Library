// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ProprietaryData7ValidatorTests
{
    private readonly ProprietaryData7Validator _sut = new();

    private static ProprietaryData7 ValidMessage() =>
        new()
        {
            Type = "PaymentInstruction",
            Data = new ProprietaryData6 { Any = new ExternalSchema.SkipPayload() },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
