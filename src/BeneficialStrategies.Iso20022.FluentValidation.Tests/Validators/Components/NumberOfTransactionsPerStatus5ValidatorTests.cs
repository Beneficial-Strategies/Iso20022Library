// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class NumberOfTransactionsPerStatus5ValidatorTests
{
    private readonly NumberOfTransactionsPerStatus5Validator _sut = new();

    private static NumberOfTransactionsPerStatus5 ValidMessage() =>
        new()
        {
            DetailedNumberOfTransactions = "1",
            DetailedStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with { DetailedControlSum = 100.00m };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
