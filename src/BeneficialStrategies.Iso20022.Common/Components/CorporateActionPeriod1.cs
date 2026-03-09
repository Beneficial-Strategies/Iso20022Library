// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods.
/// </summary>
[IsoId("_Tfs_F9p-Ed-ak6NoX_4Aeg_780421229")]
[DisplayName("Corporate Action Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, eg, offer period.
    /// </summary>
    [IsoId("_Tf2JANp-Ed-ak6NoX_4Aeg_251714373")]
    [DisplayName("Action Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnPrd")]
    #endif
    [IsoXmlTag("ActnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? ActionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? ActionPeriod { get; init; } 
    #else
    public Period1? ActionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during a take-over where any outstanding equity must be purchased by the take-over company.
    /// </summary>
    [IsoId("_Tf2JAdp-Ed-ak6NoX_4Aeg_884175340")]
    [DisplayName("Compulsory Purchase Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmplsryPurchsPrd")]
    #endif
    [IsoXmlTag("CmplsryPurchsPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? CompulsoryPurchasePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? CompulsoryPurchasePeriod { get; init; } 
    #else
    public Period1? CompulsoryPurchasePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_Tf2JAtp-Ed-ak6NoX_4Aeg_1584193885")]
    [DisplayName("Interest Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPrd")]
    #endif
    [IsoXmlTag("IntrstPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? InterestPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? InterestPeriod { get; init; } 
    #else
    public Period1? InterestPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the security is blocked.
    /// </summary>
    [IsoId("_Tf2JA9p-Ed-ak6NoX_4Aeg_786981224")]
    [DisplayName("Blocking Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckgPrd")]
    #endif
    [IsoXmlTag("BlckgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? BlockingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? BlockingPeriod { get; init; } 
    #else
    public Period1? BlockingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_Tf2JBNp-Ed-ak6NoX_4Aeg_-1721808638")]
    [DisplayName("Price Calculation Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricClctnPrd")]
    #endif
    [IsoXmlTag("PricClctnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? PriceCalculationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? PriceCalculationPeriod { get; init; } 
    #else
    public Period1? PriceCalculationPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
