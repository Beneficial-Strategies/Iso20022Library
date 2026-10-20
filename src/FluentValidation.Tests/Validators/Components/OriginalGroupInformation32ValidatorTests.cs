// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupInformation32ValidatorTests
{
    private readonly OriginalGroupInformation32Validator _sut = new();

    private static IOriginalGroupInformation32 ValidMessage() =>
        IsoDataFactory.Make<IOriginalGroupInformation32>(b => b
            .Set(x => x.OriginalMessageIdentification).To("MSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pain.013.001.12"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupStatus).To(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation)
            .Set(x => x.NumberOfTransactionsPerStatus).To([
                IsoDataFactory.Make<INumberOfTransactionsPerStatus5>(b2 => b2
                    .Set(x2 => x2.DetailedNumberOfTransactions).To("1")
                    .Set(x2 => x2.DetailedStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation)),
            ])
            .Set(x => x.OriginalControlSum).To(100.00m)
            .Set(x => x.OriginalCreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.OriginalNumberOfTransactions).To("1")
            .Set(x => x.StatusReasonInformation).To([IsoDataFactory.Make<IStatusReasonInformation14>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
