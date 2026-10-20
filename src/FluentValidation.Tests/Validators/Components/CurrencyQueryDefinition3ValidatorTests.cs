// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyQueryDefinition3ValidatorTests
{
    private readonly CurrencyQueryDefinition3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ICurrencyQueryDefinition3>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QueryType_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ICurrencyQueryDefinition3>(b => b
            .Set(x => x.QueryType).To(QueryType2Code.Modified));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CurrencyCriteria_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ICurrencyQueryDefinition3>(b => b
            .Set(x => x.CurrencyCriteria).To(IsoDataFactory.Make<Choices.CurrencyCriteriaDefinition1Choice.IQueryName>(b2 => b2
                .Set(x2 => x2.Value).To("PREVIOUS-QUERY"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
