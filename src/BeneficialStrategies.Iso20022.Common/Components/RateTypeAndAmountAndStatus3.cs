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
/// Specifies the value expressed as a rate and an amount.
/// </summary>
[IsoId("_UOpIttp-Ed-ak6NoX_4Aeg_-853623387")]
[DisplayName("Rate Type And Amount And Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateTypeAndAmountAndStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RateTypeAndAmountAndStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RateTypeAndAmountAndStatus3( RateType6Choice_ reqRateType,ActiveCurrencyAnd13DecimalAmount reqAmount )
    {
        RateType = reqRateType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_UOpIt9p-Ed-ak6NoX_4Aeg_-853622525")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateType6Choice_ RateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateType6Choice_ RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType6Choice_ RateType { get; init; } 
    #else
    public RateType6Choice_ RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_UOpIuNp-Ed-ak6NoX_4Aeg_-853622990")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_UOpIudp-Ed-ak6NoX_4Aeg_-853622586")]
    [DisplayName("Rate Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateSts")]
    #endif
    [IsoXmlTag("RateSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateStatus1Choice_? RateStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateStatus1Choice_? RateStatus { get; init; } 
    #else
    public RateStatus1Choice_? RateStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
