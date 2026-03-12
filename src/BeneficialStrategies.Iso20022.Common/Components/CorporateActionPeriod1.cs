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
[IsoId("_Tfs_F9p-Ed-ak6NoX_4Aeg_780421229")]
[DisplayName("Corporate Action Period")]
public partial record CorporateActionPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, eg, offer period.
    /// </summary>
    [IsoId("_Tf2JANp-Ed-ak6NoX_4Aeg_251714373")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period1? ActionPeriod { get; init; } 
    
    /// <summary>
    /// Period during a take-over where any outstanding equity must be purchased by the take-over company.
    /// </summary>
    [IsoId("_Tf2JAdp-Ed-ak6NoX_4Aeg_884175340")]
    [DisplayName("Compulsory Purchase Period")]
    [IsoXmlTag("CmplsryPurchsPrd")]
    public Period1? CompulsoryPurchasePeriod { get; init; } 
    
    /// <summary>
    /// Period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_Tf2JAtp-Ed-ak6NoX_4Aeg_1584193885")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public Period1? InterestPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the security is blocked.
    /// </summary>
    [IsoId("_Tf2JA9p-Ed-ak6NoX_4Aeg_786981224")]
    [DisplayName("Blocking Period")]
    [IsoXmlTag("BlckgPrd")]
    public Period1? BlockingPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_Tf2JBNp-Ed-ak6NoX_4Aeg_-1721808638")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period1? PriceCalculationPeriod { get; init; } 
    
    
    #nullable disable
    
}
