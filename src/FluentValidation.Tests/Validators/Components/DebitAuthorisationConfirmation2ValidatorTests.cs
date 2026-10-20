// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DebitAuthorisationConfirmation2ValidatorTests
{
    private readonly DebitAuthorisationConfirmation2Validator _sut = new();

    private static IDebitAuthorisationConfirmation2 ValidMessage() =>
        IsoDataFactory.Make<IDebitAuthorisationConfirmation2>(b => b
            .Set(x => x.DebitAuthorisation).To(true));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AmountToDebit).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.ValueDateToDebit).To(new DateOnly(2026, 1, 1))
            .Set(x => x.Reason).To("Approved with conditions"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
