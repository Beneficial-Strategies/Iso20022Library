// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates how the amount of the investment plan is split amongst the funds.
/// </summary>
[IsoId("_xu_QMQjcEeS5F6qHcKOrew")]
[DisplayName("Repartition")]
public partial record Repartition3
{
    #nullable enable
    
    /// <summary>
    /// Amount, units or percentage of financial instrument invested or withdrawn.
    /// </summary>
    [IsoId("_yKXkoQjcEeS5F6qHcKOrew")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required UnitsOrAmountOrPercentage1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_yKXkowjcEeS5F6qHcKOrew")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required FinancialInstrument29 FinancialInstrument { get; init; } 
    
    /// <summary>
    /// When a fund has multiple currencies within same ISIN, this indicates the currency of the savings or withdrawal plan.
    /// </summary>
    [IsoId("_yKXkpQjcEeS5F6qHcKOrew")]
    [DisplayName("Currency Of Plan")]
    [IsoXmlTag("CcyOfPlan")]
    public CurrencyCode? CurrencyOfPlan { get; init; } 
    
    
    #nullable disable
    
}
