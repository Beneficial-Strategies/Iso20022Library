// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class LimitType1Choice_ValidatorTests
{
    private readonly LimitType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.LimitType1Choice.ICode>(b => b
            .Set(x => x.Value).To(LimitType3Code.Bilateral));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.LimitType1Choice.IProprietary>(b => b
            .Set(x => x.Value).To("MYLIMIT"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
