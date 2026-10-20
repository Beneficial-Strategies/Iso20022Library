// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceAmount4ValidatorTests
{
    private readonly RemittanceAmount4Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IRemittanceAmount4>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IRemittanceAmount4>(b => b
            .Set(x => x.AdjustmentAmountAndReason).To([
                IsoDataFactory.Make<IDocumentAdjustment1>(b2 => b2
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m })),
            ])
            .Set(x => x.RemittanceAmountAndType).To([
                IsoDataFactory.Make<IDocumentAmount1>(b2 => b2
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                    .Set(x2 => x2.Type).To(IsoDataFactory.Make<Choices.DocumentAmountType1Choice.IProprietary>(b3 => b3
                        .Set(x3 => x3.Value).To("MYAMTTYPE")))),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
