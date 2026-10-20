// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class FundConfirmedCashForecastReport1ValidatorTests
{
    private readonly FundConfirmedCashForecastReport1Validator _sut = new();

    private static IFundCashForecast1 MinimalItem() =>
        IsoDataFactory.Make<IFundCashForecast1>(b => b
            .Set(x => x.TradeDateTime).To(IsoDataFactory.Make<Choices.DateAndDateTimeChoice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.FinancialInstrumentDetails).To(IsoDataFactory.Make<IFinancialInstrument5>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.SecurityIdentification1Choice.IISIN>(b3 => b3
                    .Set(x3 => x3.Value).To("US0378331005")))
                .Set(x2 => x2.DualFundIndicator).To(false)))
            .Set(x => x.ExceptionalNetCashFlowIndicator).To(false));

    private static IFundConfirmedCashForecastReport1 ValidMessage() =>
        IsoDataFactory.Make<IFundConfirmedCashForecastReport1>(b => b
            .Set(x => x.FundCashForecastDetails).To([MinimalItem()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── FundCashForecastDetails: FundCashForecast1, 1..∞ ──────────────────────

    [Fact]
    public void FundCashForecastDetails_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.FundCashForecastDetails).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.FundCashForecastDetails);
    }

    [Fact]
    public void FundCashForecastDetails_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.FundCashForecastDetails).To([MinimalItem()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.FundCashForecastDetails);
    }
}
