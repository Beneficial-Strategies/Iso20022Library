// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DatePeriod3ValidatorTests
{
    private readonly DatePeriod3Validator _sut = new();

    private static IDatePeriod3 ValidMessage() => IsoDataFactory.Make<IDatePeriod3>(b => b
        .Set(x => x.FromDate).To(new DateOnly(2026, 1, 1)));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ToDate_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ToDate).To(new DateOnly(2026, 12, 31)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
