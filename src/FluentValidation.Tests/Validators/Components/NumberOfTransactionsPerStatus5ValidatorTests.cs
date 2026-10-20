// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class NumberOfTransactionsPerStatus5ValidatorTests
{
    private readonly NumberOfTransactionsPerStatus5Validator _sut = new();

    private static INumberOfTransactionsPerStatus5 ValidMessage() =>
        IsoDataFactory.Make<INumberOfTransactionsPerStatus5>(b => b
            .Set(x => x.DetailedNumberOfTransactions).To("1")
            .Set(x => x.DetailedStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DetailedControlSum).To(100.00m));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
