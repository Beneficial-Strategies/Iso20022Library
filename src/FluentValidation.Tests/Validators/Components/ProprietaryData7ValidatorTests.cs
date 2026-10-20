// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ProprietaryData7ValidatorTests
{
    private readonly ProprietaryData7Validator _sut = new();

    private static IProprietaryData7 ValidMessage() =>
        IsoDataFactory.Make<IProprietaryData7>(b => b
            .Set(x => x.Type).To("PaymentInstruction")
            .Set(x => x.Data).To(IsoDataFactory.Make<IProprietaryData6>(b2 => b2
                .Set(x2 => x2.Any).To(new ExternalSchema.SkipPayload()))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
