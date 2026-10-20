// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DatePeriod2ValidatorTests
{
    private readonly DatePeriod2Validator _sut = new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IDatePeriod2>(b => b
            .Set(x => x.FromDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.ToDate).To(new DateOnly(2026, 12, 31)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
