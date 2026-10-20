// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GenericPersonIdentification2ValidatorTests
{
    private readonly GenericPersonIdentification2Validator _sut = new();

    private static IGenericPersonIdentification2 ValidMessage() =>
        IsoDataFactory.Make<IGenericPersonIdentification2>(b => b
            .Set(x => x.Identification).To("PERS-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SchemeName_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SchemeName).To(IsoDataFactory.Make<Choices.PersonIdentificationSchemeName1Choice.IProprietary>(b2 => b2
                    .Set(x2 => x2.Value).To("MYSCHEME"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
