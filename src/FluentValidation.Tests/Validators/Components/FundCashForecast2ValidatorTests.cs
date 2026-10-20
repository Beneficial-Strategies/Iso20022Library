// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class FundCashForecast2ValidatorTests
{
    private readonly FundCashForecast2Validator _sut = new();

    private static ICashInForecast1 ValidCashIn(bool? exceptional = null) =>
        IsoDataFactory.Make<ICashInForecast1>(b => b
            .Set(x => x.SettlementDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.ExceptionalCashFlowIndicator).To(exceptional));

    private static IForecastParameter2 ValidForecastBreakdownDetail(bool? exceptional = null) =>
        IsoDataFactory.Make<IForecastParameter2>(b => b
            .Set(x => x.ReportParameter).To(IsoDataFactory.Make<Choices.ReportParameter2Choice.ICountry>(b2 => b2
                .Set(x2 => x2.Value).To("US")))
            .Set(x => x.CashInForecastDetails).To(exceptional is null ? [] : [ValidCashIn(exceptional)]));

    private static ICashSortingCriterion2 ValidSortingCriteria(bool? exceptional = null) =>
        IsoDataFactory.Make<ICashSortingCriterion2>(b => b
            .Set(x => x.SortingCriterionType).To(IsoDataFactory.Make<Choices.SortCriteria1Choice.IUserDefined>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<Choices.DataFormat1Choice.IUnstructured>(b3 => b3
                .Set(x3 => x3.Value).To("FORMAT")))))
            .Set(x => x.ForecastBreakdownDetails).To([ValidForecastBreakdownDetail(exceptional)]));

    private static IFundCashForecast2 ValidMessage() =>
        IsoDataFactory.Make<IFundCashForecast2>(b => b
            .Set(x => x.TradeDateTime).To(IsoDataFactory.Make<Choices.DateAndDateTimeChoice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.FinancialInstrumentDetails).To(IsoDataFactory.Make<IFinancialInstrument5>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.SecurityIdentification1Choice.IISIN>(b3 => b3
                    .Set(x3 => x3.Value).To("US0378331005")))
                .Set(x2 => x2.DualFundIndicator).To(false)))
            .Set(x => x.ExceptionalNetCashFlowIndicator).To(false)
            .Set(x => x.SortingCriteriaDetails).To([ValidSortingCriteria()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── SortingCriteriaDetails: CashSortingCriterion2, 1..∞ ───────────────────

    [Fact]
    public void SortingCriteriaDetails_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SortingCriteriaDetails).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.SortingCriteriaDetails);
    }

    // ── ExceptionalCashFlowIndicatorRule ──────────────────────────────────────

    [Fact]
    public void ExceptionalIndicatorTrue_NoMatchingNestedIndicator_Violates_Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ExceptionalNetCashFlowIndicator).To(true)
            .Set(x => x.SortingCriteriaDetails).To([ValidSortingCriteria(exceptional: false)]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExceptionalCashFlowIndicatorRule");
    }

    [Fact]
    public void ExceptionalIndicatorTrue_MatchingNestedIndicator_DoesNotViolate_Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ExceptionalNetCashFlowIndicator).To(true)
            .Set(x => x.SortingCriteriaDetails).To([ValidSortingCriteria(exceptional: true)]));
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
