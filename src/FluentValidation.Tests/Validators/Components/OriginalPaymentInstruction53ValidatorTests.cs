// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalPaymentInstruction53ValidatorTests
{
    private readonly OriginalPaymentInstruction53Validator _sut = new();

    private static OriginalPaymentInstruction53 ValidMessage() =>
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
            ReversalPaymentInformationIdentification = "RVSLPMTINF-001",
            OriginalNumberOfTransactions = "1",
            OriginalControlSum = 100.00m,
            BatchBooking = true,
            PaymentInformationReversal = false,
            ReversalReasonInformation = [new PaymentReversalReason10()],
            TransactionInformation = [new PaymentTransaction174()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
