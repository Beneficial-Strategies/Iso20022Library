// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DatePeriod2ValidatorTests
{
    private readonly DatePeriod2Validator _sut = new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        var msg = new DatePeriod2 { FromDate = new DateOnly(2026, 1, 1), ToDate = new DateOnly(2026, 12, 31) };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
