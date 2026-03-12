// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods.
/// </summary>
[IsoId("_kGhRs7QYEeeKRKrD60ELBQ")]
[DisplayName("Corporate Action Period")]
public partial record CorporateActionPeriod13
{
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_kWJCA7QYEeeKRKrD60ELBQ")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period11? PriceCalculationPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_kWJCB7QYEeeKRKrD60ELBQ")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period11? ActionPeriod { get; init; } 
    
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_kWJCC7QYEeeKRKrD60ELBQ")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period11? ParallelTradingPeriod { get; init; } 
    
    
    #nullable disable
    
}
