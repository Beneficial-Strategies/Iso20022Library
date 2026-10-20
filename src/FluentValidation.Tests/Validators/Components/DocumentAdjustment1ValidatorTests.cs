// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentAdjustment1ValidatorTests
{
    private readonly DocumentAdjustment1Validator _sut = new();

    private static IDocumentAdjustment1 ValidMessage() =>
        IsoDataFactory.Make<IDocumentAdjustment1>(b => b
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m }));

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
            .Set(x => x.Reason).To("ADJ1")
            .Set(x => x.AdditionalInformation).To("Adjustment note"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
