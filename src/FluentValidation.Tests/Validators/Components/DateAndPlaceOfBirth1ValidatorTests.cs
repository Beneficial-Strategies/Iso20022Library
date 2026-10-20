// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DateAndPlaceOfBirth1ValidatorTests
{
    private readonly DateAndPlaceOfBirth1Validator _sut = new();

    private static DateAndPlaceOfBirth1 ValidMessage() =>
        new()
        {
            BirthDate = new DateOnly(1990, 1, 1),
            CityOfBirth = "Springfield",
            CountryOfBirth = "US",
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProvinceOfBirth_Present_NoValidationError()
    {
        var msg = ValidMessage() with { ProvinceOfBirth = "Illinois" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
