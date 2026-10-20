// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupHeader22ValidatorTests
{
    private readonly OriginalGroupHeader22Validator _sut = new();

    private static OriginalGroupHeader22 ValidMessage() =>
        new() { OriginalMessageIdentification = "MSG-001", OriginalMessageNameIdentification = "pain.001.001.13" };

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
            GroupStatus = ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation,
            NumberOfTransactionsPerStatus =
            [
                new NumberOfTransactionsPerStatus5
                {
                    DetailedNumberOfTransactions = "1",
                    DetailedStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
                },
            ],
            OriginalControlSum = 100.00m,
            OriginalCreationDateTime = new DateTime(2026, 1, 1),
            OriginalNumberOfTransactions = "1",
            StatusReasonInformation = [new StatusReasonInformation14()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
