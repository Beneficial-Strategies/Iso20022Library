// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class GeneralBusinessInformationCriteriaDefinition1Choice_ValidatorTests
{
    private readonly GeneralBusinessInformationCriteriaDefinition1Choice_Validator _sut = new();

    [Fact]
    public void QueryNameVariant_NoValidationErrors()
    {
        var value =
            IsoDataFactory.Make<Choices.GeneralBusinessInformationCriteriaDefinition1Choice.IQueryName>(b => b
                .Set(x => x.Value).To("PREVIOUS-QUERY"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_Empty_NoValidationErrors()
    {
        var value =
            IsoDataFactory.Make<Choices.GeneralBusinessInformationCriteriaDefinition1Choice.INewCriteria>();
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewCriteriaVariant_AllFieldsPresent_NoValidationErrors()
    {
        var value =
            IsoDataFactory.Make<Choices.GeneralBusinessInformationCriteriaDefinition1Choice.INewCriteria>(b => b
                .Set(x => x.NewQueryName).To("NEW-QUERY")
                .Set(x => x.SearchCriteria).To([IsoDataFactory.Make<IGeneralBusinessInformationSearchCriteria1>(b2 => b2
                    .Set(x2 => x2.Reference).To(["REF-001"]))])
                .Set(x => x.ReturnCriteria).To(IsoDataFactory.Make<IGeneralBusinessInformationReturnCriteria1>(b2 => b2
                    .Set(x2 => x2.QualifierIndicator).To(true))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
