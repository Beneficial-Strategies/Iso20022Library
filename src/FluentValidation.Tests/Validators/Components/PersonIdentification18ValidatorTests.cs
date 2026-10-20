// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PersonIdentification18ValidatorTests
{
    private readonly PersonIdentification18Validator _sut = new();

    private static PersonIdentification18 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            DateAndPlaceOfBirth = new DateAndPlaceOfBirth1
            {
                BirthDate = new DateOnly(1990, 1, 1),
                CityOfBirth = "Springfield",
                CountryOfBirth = "US",
            },
            Other = [new GenericPersonIdentification2 { Identification = "PERS-001" }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
