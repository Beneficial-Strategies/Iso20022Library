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
[IsoId("_yH035VksEeSiQOnYSp7BZg")]
[DisplayName("Corporate Action Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPeriod11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_ylSPk1ksEeSiQOnYSp7BZg")]
    [DisplayName("Price Calculation Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricClctnPrd")]
    #endif
    [IsoXmlTag("PricClctnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4? PriceCalculationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4? PriceCalculationPeriod { get; init; } 
    #else
    public Period4? PriceCalculationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_ylSPm1ksEeSiQOnYSp7BZg")]
    [DisplayName("Action Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnPrd")]
    #endif
    [IsoXmlTag("ActnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4? ActionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4? ActionPeriod { get; init; } 
    #else
    public Period4? ActionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_ylSPo1ksEeSiQOnYSp7BZg")]
    [DisplayName("Parallel Trading Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParllTradgPrd")]
    #endif
    [IsoXmlTag("ParllTradgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4? ParallelTradingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4? ParallelTradingPeriod { get; init; } 
    #else
    public Period4? ParallelTradingPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
