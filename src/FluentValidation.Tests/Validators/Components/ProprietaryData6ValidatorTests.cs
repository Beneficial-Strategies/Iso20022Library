// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ProprietaryData6ValidatorTests
{
    private readonly ProprietaryData6Validator _sut = new();

    private static IProprietaryData6 ValidMessage() => IsoDataFactory.Make<IProprietaryData6>(b => b
        .Set(x => x.Any).To(new ExternalSchema.SkipPayload()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
