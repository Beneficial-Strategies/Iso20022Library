// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.CurrencyExchangeSearchCriteria1.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>CurrencyExchangeSearchCriteria1</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>CurrencyExchangeSearchCriteria1</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Components.ICurrencyExchangeSearchCriteria1 Minimal =>
        IsoDataFactory.Make<ICurrencyExchangeSearchCriteria1>(b2 => b2
                    .Set(x2 => x2.SourceCurrency).To("USD")
                    .Set(x2 => x2.TargetCurrency).To("EUR"));
}
