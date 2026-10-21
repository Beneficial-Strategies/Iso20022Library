// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CurrencyCriteriaDefinition1Choice.Valid;

/// <summary>Valid samples of <c>NewCriteria</c> of <c>CurrencyCriteriaDefinition1Choice</c>.</summary>
public static class NewCriteria
{
    /// <summary>A valid <c>NewCriteria</c> of <c>CurrencyCriteriaDefinition1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CurrencyCriteriaDefinition1Choice.INewCriteria Minimal =>
        IsoDataFactory.Make<Choices.CurrencyCriteriaDefinition1Choice.INewCriteria>();

    /// <summary>A valid <c>NewCriteria</c> of <c>CurrencyCriteriaDefinition1Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static Choices.CurrencyCriteriaDefinition1Choice.INewCriteria Maximal =>
        IsoDataFactory.Make<Choices.CurrencyCriteriaDefinition1Choice.INewCriteria>(b => b
                .Set(x => x.SearchCriteria).To([Samples.CurrencyExchangeSearchCriteria1.Valid.Standard.Minimal]));
}
