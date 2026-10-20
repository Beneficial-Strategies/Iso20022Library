// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PersonIdentification18ValidatorTests
{
    private readonly PersonIdentification18Validator _sut = new();

    private static IPersonIdentification18 ValidMessage() => IsoDataFactory.Make<IPersonIdentification18>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DateAndPlaceOfBirth).To(IsoDataFactory.Make<IDateAndPlaceOfBirth1>(b2 => b2
                .Set(x2 => x2.BirthDate).To(new DateOnly(1990, 1, 1))
                .Set(x2 => x2.CityOfBirth).To("Springfield")
                .Set(x2 => x2.CountryOfBirth).To("US")))
            .Set(x => x.Other).To([IsoDataFactory.Make<IGenericPersonIdentification2>(b2 => b2
                .Set(x2 => x2.Identification).To("PERS-001"))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
