// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxPeriod3ValidatorTests
{
    private readonly TaxPeriod3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ITaxPeriod3>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ITaxPeriod3>(b => b
            .Set(x => x.Year).To(2026)
            .Set(x => x.Type).To(TaxRecordPeriod1Code.FirstMonth)
            .Set(x => x.FromToDate).To(IsoDataFactory.Make<IDatePeriod2>(b2 => b2
                .Set(x2 => x2.FromDate).To(new DateOnly(2026, 1, 1))
                .Set(x2 => x2.ToDate).To(new DateOnly(2026, 12, 31)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
