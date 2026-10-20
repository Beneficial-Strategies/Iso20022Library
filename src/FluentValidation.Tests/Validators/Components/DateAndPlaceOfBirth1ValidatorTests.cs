// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DateAndPlaceOfBirth1ValidatorTests
{
    private readonly DateAndPlaceOfBirth1Validator _sut = new();

    private static IDateAndPlaceOfBirth1 ValidMessage() =>
        IsoDataFactory.Make<IDateAndPlaceOfBirth1>(b => b
            .Set(x => x.BirthDate).To(new DateOnly(1990, 1, 1))
            .Set(x => x.CityOfBirth).To("Springfield")
            .Set(x => x.CountryOfBirth).To("US"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProvinceOfBirth_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ProvinceOfBirth).To("Illinois"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
