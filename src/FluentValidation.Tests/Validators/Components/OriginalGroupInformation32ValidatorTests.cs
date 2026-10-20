// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupInformation32ValidatorTests
{
    private readonly OriginalGroupInformation32Validator _sut = new();

    private static OriginalGroupInformation32 ValidMessage() =>
        new() { OriginalMessageIdentification = "MSG-001", OriginalMessageNameIdentification = "pain.013.001.12" };

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
