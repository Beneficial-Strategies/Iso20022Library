// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CurrencyCriteriaDefinition1Choice_ValidatorTests
{
    private readonly CurrencyCriteriaDefinition1Choice_Validator _sut = new();

    [Fact]
    public void QueryNameVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.QueryName
        {
            Value = "PREVIOUS-QUERY",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.NewCriteria
        {
            SearchCriteria = [new CurrencyExchangeSearchCriteria1 { SourceCurrency = "USD", TargetCurrency = "EUR" }],
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_Empty_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.NewCriteria();
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
