// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalPaymentInstruction56ValidatorTests
{
    private readonly OriginalPaymentInstruction56Validator _sut = new();

    private static OriginalPaymentInstruction56 ValidMessage() =>
        new() { OriginalPaymentInformationIdentification = "PMTINF-001" };

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
            OriginalNumberOfTransactions = "1",
            OriginalControlSum = 100.00m,
            PaymentInformationStatus = ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation,
            StatusReasonInformation = [new StatusReasonInformation14()],
            NumberOfTransactionsPerStatus =
            [
                new NumberOfTransactionsPerStatus5
                {
                    DetailedNumberOfTransactions = "1",
                    DetailedStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
                },
            ],
            TransactionInformationAndStatus = [new PaymentTransaction178()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
