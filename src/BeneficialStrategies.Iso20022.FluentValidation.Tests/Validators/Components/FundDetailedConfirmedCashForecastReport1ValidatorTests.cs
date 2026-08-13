// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class FundDetailedConfirmedCashForecastReport1ValidatorTests
{
    private readonly FundDetailedConfirmedCashForecastReport1Validator _sut = new();

    private static FundCashForecast2 MinimalItem() =>
        new()
        {
            TradeDateTime = new Choices.DateAndDateTimeChoice.Date { Value = new DateOnly(2026, 1, 1) },
            FinancialInstrumentDetails = new FinancialInstrument5
            {
                Identification = new Choices.SecurityIdentification1Choice.ISIN { Value = "US0378331005" },
                DualFundIndicator = false,
            },
            ExceptionalNetCashFlowIndicator = false,
        };

    private static FundDetailedConfirmedCashForecastReport1 ValidMessage() =>
        new() { FundCashForecastDetails = [MinimalItem()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── FundCashForecastDetails: FundCashForecast2, 1..∞ ──────────────────────

    [Fact]
    public void FundCashForecastDetails_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { FundCashForecastDetails = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.FundCashForecastDetails);
    }

    [Fact]
    public void FundCashForecastDetails_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { FundCashForecastDetails = [MinimalItem()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.FundCashForecastDetails);
    }
}
