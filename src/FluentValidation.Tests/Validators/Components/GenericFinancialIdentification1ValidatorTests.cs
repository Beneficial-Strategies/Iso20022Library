// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GenericFinancialIdentification1ValidatorTests
{
    private readonly GenericFinancialIdentification1Validator _sut = new();

    private static IGenericFinancialIdentification1 ValidMessage() =>
        IsoDataFactory.Make<IGenericFinancialIdentification1>(b => b
            .Set(x => x.Identification).To("ID-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SchemeName_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SchemeName).To(IsoDataFactory.Make<Choices.FinancialIdentificationSchemeName1Choice.IProprietary>(b2 => b2
                    .Set(x2 => x2.Value).To("MYSCHEME"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
