// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class NameAndAddress18ValidatorTests
{
    private readonly NameAndAddress18Validator _sut = new();

    private static INameAndAddress18 ValidMessage() =>
        IsoDataFactory.Make<INameAndAddress18>(b => b
            .Set(x => x.Name).To("Jane Doe")
            .Set(x => x.Address).To(IsoDataFactory.Make<IPostalAddress27>()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
