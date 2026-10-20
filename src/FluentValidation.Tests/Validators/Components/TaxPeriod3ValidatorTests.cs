// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxPeriod3ValidatorTests
{
    private readonly TaxPeriod3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new TaxPeriod3()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new TaxPeriod3
        {
            Year = 2026,
            Type = TaxRecordPeriod1Code.FirstMonth,
            FromToDate = new DatePeriod2 { FromDate = new DateOnly(2026, 1, 1), ToDate = new DateOnly(2026, 12, 31) },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
