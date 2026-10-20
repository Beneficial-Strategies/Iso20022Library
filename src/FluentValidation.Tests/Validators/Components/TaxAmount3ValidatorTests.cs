// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxAmount3ValidatorTests
{
    private readonly TaxAmount3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ITaxAmount3>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ITaxAmount3>(b => b
            .Set(x => x.Rate).To(5.5m)
            .Set(x => x.TaxableBaseAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 1000m })
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 55m })
            .Set(x => x.Details).To([
                IsoDataFactory.Make<ITaxRecordDetails3>(b2 => b2
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 55m })),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
