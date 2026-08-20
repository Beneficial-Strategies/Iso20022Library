// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DebitAuthorisationConfirmation2ValidatorTests
{
    private readonly DebitAuthorisationConfirmation2Validator _sut = new();

    private static DebitAuthorisationConfirmation2 ValidMessage() =>
        new() { DebitAuthorisation = true };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            AmountToDebit = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
            ValueDateToDebit = new DateOnly(2026, 1, 1),
            Reason = "Approved with conditions",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
