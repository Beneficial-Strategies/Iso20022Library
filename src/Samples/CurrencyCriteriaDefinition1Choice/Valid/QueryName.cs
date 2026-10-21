// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CurrencyCriteriaDefinition1Choice.Valid;

/// <summary>Valid samples of <c>QueryName</c> of <c>CurrencyCriteriaDefinition1Choice</c>.</summary>
public static class QueryName
{
    /// <summary>A valid <c>QueryName</c> of <c>CurrencyCriteriaDefinition1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CurrencyCriteriaDefinition1Choice.IQueryName Minimal =>
        IsoDataFactory.Make<Choices.CurrencyCriteriaDefinition1Choice.IQueryName>(b => b
                .Set(x => x.Value).To("PREVIOUS-QUERY"));
}
