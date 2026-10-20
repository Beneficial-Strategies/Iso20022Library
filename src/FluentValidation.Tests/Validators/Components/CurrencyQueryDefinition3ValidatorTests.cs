// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyQueryDefinition3ValidatorTests
{
    private readonly CurrencyQueryDefinition3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new CurrencyQueryDefinition3()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QueryType_Present_NoValidationError()
    {
        var msg = new CurrencyQueryDefinition3 { QueryType = QueryType2Code.Modified };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CurrencyCriteria_Present_NoValidationError()
    {
        var msg = new CurrencyQueryDefinition3
        {
            CurrencyCriteria = new BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.QueryName
            {
                Value = "PREVIOUS-QUERY",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
