// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Reservation4ValidatorTests
{
    private readonly Reservation4Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.Amount2Choice_ ValidAmount() =>
        new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency { Currency = "USD", Amount = 100m };

    private static Reservation4 ValidMessage() => new() { Amount = ValidAmount() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void StartDateTime_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            StartDateTime = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
