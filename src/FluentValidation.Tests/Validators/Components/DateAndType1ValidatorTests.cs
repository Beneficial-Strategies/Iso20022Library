// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DateAndType1ValidatorTests
{
    private readonly DateAndType1Validator _sut = new();

    private static IDateAndType1 ValidMessage() =>
        IsoDataFactory.Make<IDateAndType1>(b => b
            .Set(x => x.Date).To(new DateOnly(2026, 1, 1))
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.DateType2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYDATETYPE"))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
