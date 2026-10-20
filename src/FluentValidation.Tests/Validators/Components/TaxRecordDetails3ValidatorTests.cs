// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxRecordDetails3ValidatorTests
{
    private readonly TaxRecordDetails3Validator _sut = new();

    private static ITaxRecordDetails3 ValidMessage() =>
        IsoDataFactory.Make<ITaxRecordDetails3>(b => b
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m }));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Period).To(IsoDataFactory.Make<ITaxPeriod3>(b2 => b2
                .Set(x2 => x2.Year).To(2026))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
