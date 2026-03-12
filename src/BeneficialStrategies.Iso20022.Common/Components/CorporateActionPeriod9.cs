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
[IsoId("_1ncZMfZFEd-2Jsl2KtUQCw")]
[DisplayName("Corporate Action Period")]
public partial record CorporateActionPeriod9
{
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_1ncZM_ZFEd-2Jsl2KtUQCw")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period5? PriceCalculationPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_1ncZNfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period5? ActionPeriod { get; init; } 
    
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_1ncZN_ZFEd-2Jsl2KtUQCw")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period5? ParallelTradingPeriod { get; init; } 
    
    
    #nullable disable
    
}
