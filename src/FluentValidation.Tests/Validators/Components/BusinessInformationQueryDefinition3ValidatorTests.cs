// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BusinessInformationQueryDefinition3ValidatorTests
{
    private readonly BusinessInformationQueryDefinition3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IBusinessInformationQueryDefinition3>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IBusinessInformationQueryDefinition3>(b => b
            .Set(x => x.QueryType).To(QueryType2Code.Modified)
            .Set(x => x.GeneralBusinessInformationCriteria).To(IsoDataFactory.Make<Choices.GeneralBusinessInformationCriteriaDefinition1Choice.IQueryName>(b2 => b2
                    .Set(x2 => x2.Value).To("PREVIOUS-QUERY"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
