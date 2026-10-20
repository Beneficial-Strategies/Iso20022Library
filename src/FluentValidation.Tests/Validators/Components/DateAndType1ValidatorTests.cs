// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DateAndType1ValidatorTests
{
    private readonly DateAndType1Validator _sut = new();

    private static DateAndType1 ValidMessage() =>
        new()
        {
            Date = new DateOnly(2026, 1, 1),
            Type = new BeneficialStrategies.Iso20022.Choices.DateType2Choice.Proprietary
            {
                Value = "MYDATETYPE",
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
