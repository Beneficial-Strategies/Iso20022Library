// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalPaymentInstruction56ValidatorTests
{
    private readonly OriginalPaymentInstruction56Validator _sut = new();

    private static IOriginalPaymentInstruction56 ValidMessage() =>
        IsoDataFactory.Make<IOriginalPaymentInstruction56>(b => b
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
            .Set(x => x.OriginalNumberOfTransactions).To("1")
            .Set(x => x.OriginalControlSum).To(100.00m)
            .Set(x => x.PaymentInformationStatus).To(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation)
            .Set(x => x.StatusReasonInformation).To([IsoDataFactory.Make<IStatusReasonInformation14>()])
            .Set(x => x.NumberOfTransactionsPerStatus).To([
                IsoDataFactory.Make<INumberOfTransactionsPerStatus5>(b2 => b2
                    .Set(x2 => x2.DetailedNumberOfTransactions).To("1")
                    .Set(x2 => x2.DetailedStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation)),
            ])
            .Set(x => x.TransactionInformationAndStatus).To([IsoDataFactory.Make<IPaymentTransaction178>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
