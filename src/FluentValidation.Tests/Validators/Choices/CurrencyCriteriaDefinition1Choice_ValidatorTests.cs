// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CurrencyCriteriaDefinition1Choice_ValidatorTests
{
    private readonly CurrencyCriteriaDefinition1Choice_Validator _sut = new();

    [Fact]
    public void QueryNameVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.CurrencyCriteriaDefinition1Choice.Valid.QueryName.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.CurrencyCriteriaDefinition1Choice.Valid.NewCriteria.Maximal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_Empty_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.CurrencyCriteriaDefinition1Choice.Valid.NewCriteria.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
