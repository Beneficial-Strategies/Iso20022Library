// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class LimitStructure3Choice_ValidatorTests
{
    private readonly LimitStructure3Choice_Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.ILimitType1Choice ValidType() =>
        IsoDataFactory.Make<Choices.LimitType1Choice.ICode>(b => b
            .Set(x => x.Value).To(LimitType3Code.Bilateral));

    [Fact]
    public void AllCurrentLimitsVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.LimitStructure3Choice.IAllCurrentLimits>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<ILimitIdentification9>(b2 => b2
                .Set(x2 => x2.Type).To(ValidType()))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CurrentLimitIdentificationVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.LimitStructure3Choice.ICurrentLimitIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<ILimitIdentification8>(b2 => b2
                .Set(x2 => x2.Type).To(ValidType()))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
