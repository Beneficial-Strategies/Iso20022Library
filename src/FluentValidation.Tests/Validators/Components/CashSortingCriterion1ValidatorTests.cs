// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CashSortingCriterion1ValidatorTests
{
    private readonly CashSortingCriterion1Validator _sut = new();

    private static IForecastParameter1 ValidForecastBreakdownDetail() =>
        IsoDataFactory.Make<IForecastParameter1>(b => b
            .Set(x => x.ReportParameter).To(IsoDataFactory.Make<Choices.ReportParameter2Choice.ICountry>(b2 => b2
            .Set(x2 => x2.Value).To("US"))));

    private static ICashSortingCriterion1 ValidMessage() =>
        IsoDataFactory.Make<ICashSortingCriterion1>(b => b
            .Set(x => x.SortingCriterionType).To(IsoDataFactory.Make<Choices.SortCriteria1Choice.IUserDefined>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<Choices.DataFormat1Choice.IUnstructured>(b3 => b3
                .Set(x3 => x3.Value).To("FORMAT")))))
            .Set(x => x.ForecastBreakdownDetails).To([ValidForecastBreakdownDetail()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ForecastBreakdownDetails: ForecastParameter1, 1..∞ ────────────────────

    [Fact]
    public void ForecastBreakdownDetails_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ForecastBreakdownDetails).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ForecastBreakdownDetails);
    }

    [Fact]
    public void ForecastBreakdownDetails_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ForecastBreakdownDetails).To([ValidForecastBreakdownDetail()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ForecastBreakdownDetails);
    }
}
