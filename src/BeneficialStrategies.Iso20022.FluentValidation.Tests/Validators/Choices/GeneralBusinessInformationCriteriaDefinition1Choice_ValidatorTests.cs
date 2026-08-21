// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class GeneralBusinessInformationCriteriaDefinition1Choice_ValidatorTests
{
    private readonly GeneralBusinessInformationCriteriaDefinition1Choice_Validator _sut = new();

    [Fact]
    public void QueryNameVariant_NoValidationErrors()
    {
        var value =
            new BeneficialStrategies.Iso20022.Choices.GeneralBusinessInformationCriteriaDefinition1Choice.QueryName
            {
                Value = "PREVIOUS-QUERY",
            };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_Empty_NoValidationErrors()
    {
        var value =
            new BeneficialStrategies.Iso20022.Choices.GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria();
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_AllFieldsPresent_NoValidationErrors()
    {
        var value =
            new BeneficialStrategies.Iso20022.Choices.GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria
            {
                NewQueryName = "NEW-QUERY",
                SearchCriteria = new GeneralBusinessInformationSearchCriteria1 { Reference = ["REF-001"] },
                ReturnCriteria = new GeneralBusinessInformationReturnCriteria1 { QualifierIndicator = true },
            };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
