// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BusinessInformationQueryDefinition3ValidatorTests
{
    private readonly BusinessInformationQueryDefinition3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new BusinessInformationQueryDefinition3()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = new BusinessInformationQueryDefinition3
        {
            QueryType = QueryType2Code.Modified,
            GeneralBusinessInformationCriteria =
                new BeneficialStrategies.Iso20022.Choices.GeneralBusinessInformationCriteriaDefinition1Choice.QueryName
                {
                    Value = "PREVIOUS-QUERY",
                },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
