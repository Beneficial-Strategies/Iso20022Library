// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.CurrencyCriteriaDefinition1Choice.Valid;

/// <summary>Valid samples of <c>NewCriteria</c> of <c>CurrencyCriteriaDefinition1Choice</c>.</summary>
public static class NewCriteria
{
    /// <summary>A valid <c>NewCriteria</c> of <c>CurrencyCriteriaDefinition1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.INewCriteria Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.CurrencyCriteriaDefinition1Choice.INewCriteria>(b => b
                .Set(x => x.SearchCriteria).To([BeneficialStrategies.Iso20022.Samples.CurrencyExchangeSearchCriteria1.Valid.Standard.Minimal]));
}
