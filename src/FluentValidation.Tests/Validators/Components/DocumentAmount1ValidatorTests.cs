// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentAmount1ValidatorTests
{
    private readonly DocumentAmount1Validator _sut = new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IDocumentAmount1>(b => b
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.DocumentAmountType1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYAMTTYPE"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
