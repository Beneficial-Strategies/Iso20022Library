// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.CurrencyCriteriaDefinition1Choice.Valid;

/// <summary>Valid samples of the <c>NewCriteria</c> variant of <c>CurrencyCriteriaDefinition1Choice</c>.</summary>
public static class NewCriteria
{
    /// <summary>The NewCriteria variant of <c>CurrencyCriteriaDefinition1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.INewCriteria Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.INewCriteria>(b => b
                .Set(x => x.SearchCriteria).To([IsoDataFactory.Make<ICurrencyExchangeSearchCriteria1>(b2 => b2
                    .Set(x2 => x2.SourceCurrency).To("USD")
                    .Set(x2 => x2.TargetCurrency).To("EUR"))]));
}
