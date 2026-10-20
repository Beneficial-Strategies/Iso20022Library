// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalPaymentInstruction53ValidatorTests
{
    private readonly OriginalPaymentInstruction53Validator _sut = new();

    private static IOriginalPaymentInstruction53 ValidMessage() =>
        IsoDataFactory.Make<IOriginalPaymentInstruction53>(b => b
            .Set(x => x.OriginalPaymentInformationIdentification).To("PMTINF-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReversalPaymentInformationIdentification).To("RVSLPMTINF-001")
            .Set(x => x.OriginalNumberOfTransactions).To("1")
            .Set(x => x.OriginalControlSum).To(100.00m)
            .Set(x => x.BatchBooking).To(true)
            .Set(x => x.PaymentInformationReversal).To(false)
            .Set(x => x.ReversalReasonInformation).To([IsoDataFactory.Make<IPaymentReversalReason10>()])
            .Set(x => x.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction174>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
