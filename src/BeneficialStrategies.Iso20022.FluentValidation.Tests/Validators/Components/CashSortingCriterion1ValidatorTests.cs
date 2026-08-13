// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CashSortingCriterion1ValidatorTests
{
    private readonly CashSortingCriterion1Validator _sut = new();

    private static ForecastParameter1 ValidForecastBreakdownDetail() =>
        new() { ReportParameter = new Choices.ReportParameter2Choice.Country { Value = "US" } };

    private static CashSortingCriterion1 ValidMessage() =>
        new()
        {
            SortingCriterionType = new Choices.SortCriteria1Choice.UserDefined(),
            ForecastBreakdownDetails = [ValidForecastBreakdownDetail()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ForecastBreakdownDetails: ForecastParameter1, 1..∞ ────────────────────

    [Fact]
    public void ForecastBreakdownDetails_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { ForecastBreakdownDetails = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ForecastBreakdownDetails);
    }

    [Fact]
    public void ForecastBreakdownDetails_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { ForecastBreakdownDetails = [ValidForecastBreakdownDetail()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ForecastBreakdownDetails);
    }
}
