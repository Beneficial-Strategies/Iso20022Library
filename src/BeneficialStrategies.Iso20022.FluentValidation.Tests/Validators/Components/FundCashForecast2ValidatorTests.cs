// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class FundCashForecast2ValidatorTests
{
    private readonly FundCashForecast2Validator _sut = new();

    private static CashInForecast1 ValidCashIn(bool? exceptional = null) =>
        new() { SettlementDate = new DateOnly(2026, 1, 1), ExceptionalCashFlowIndicator = exceptional };

    private static ForecastParameter2 ValidForecastBreakdownDetail(bool? exceptional = null) =>
        new()
        {
            ReportParameter = new Choices.ReportParameter2Choice.Country { Value = "US" },
            CashInForecastDetails = exceptional is null ? [] : [ValidCashIn(exceptional)],
        };

    private static CashSortingCriterion2 ValidSortingCriteria(bool? exceptional = null) =>
        new()
        {
            SortingCriterionType = new Choices.SortCriteria1Choice.UserDefined(),
            ForecastBreakdownDetails = [ValidForecastBreakdownDetail(exceptional)],
        };

    private static FundCashForecast2 ValidMessage() =>
        new()
        {
            TradeDateTime = new Choices.DateAndDateTimeChoice.Date { Value = new DateOnly(2026, 1, 1) },
            FinancialInstrumentDetails = new FinancialInstrument5
            {
                Identification = new Choices.SecurityIdentification1Choice.ISIN { Value = "US0378331005" },
                DualFundIndicator = false,
            },
            ExceptionalNetCashFlowIndicator = false,
            SortingCriteriaDetails = [ValidSortingCriteria()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── SortingCriteriaDetails: CashSortingCriterion2, 1..∞ ───────────────────

    [Fact]
    public void SortingCriteriaDetails_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { SortingCriteriaDetails = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.SortingCriteriaDetails);
    }

    // ── ExceptionalCashFlowIndicatorRule ──────────────────────────────────────

    [Fact]
    public void ExceptionalIndicatorTrue_NoMatchingNestedIndicator_Violates_Rule()
    {
        var msg = ValidMessage() with
        {
            ExceptionalNetCashFlowIndicator = true,
            SortingCriteriaDetails = [ValidSortingCriteria(exceptional: false)],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExceptionalCashFlowIndicatorRule");
    }

    [Fact]
    public void ExceptionalIndicatorTrue_MatchingNestedIndicator_DoesNotViolate_Rule()
    {
        var msg = ValidMessage() with
        {
            ExceptionalNetCashFlowIndicator = true,
            SortingCriteriaDetails = [ValidSortingCriteria(exceptional: true)],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ExceptionalCashFlowIndicatorRule");
    }

    [Fact]
    public void ExceptionalIndicatorFalse_DoesNotViolate_Rule()
    {
        var result = _sut.Validate(ValidMessage());
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ExceptionalCashFlowIndicatorRule");
    }
}
