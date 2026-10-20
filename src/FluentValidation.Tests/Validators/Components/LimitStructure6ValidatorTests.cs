// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class LimitStructure6ValidatorTests
{
    private readonly LimitStructure6Validator _sut = new();

    private static ILimitIdentification8 ValidLimitIdentification() =>
        IsoDataFactory.Make<ILimitIdentification8>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.LimitType1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(LimitType3Code.Bilateral))));

    private static BeneficialStrategies.Iso20022.Choices.IAmount2Choice ValidAmount() =>
        IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b => b
            .Set(x => x.Currency).To("USD")
            .Set(x => x.Amount).To(100m));

    private static ILimitStructure6 ValidMessage() =>
        IsoDataFactory.Make<ILimitStructure6>(b => b
            .Set(x => x.LimitIdentification).To(ValidLimitIdentification())
            .Set(x => x.Amount).To(ValidAmount()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditDebitIndicator).To(CreditDebitCode.Credit)
            .Set(x => x.StartDateTime).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
