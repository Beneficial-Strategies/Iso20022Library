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
/// Information that describes a netting cut off held at a central system.
/// </summary>
[IsoId("_WkhLEJVIEeaYkf5FCqYMeA")]
[DisplayName("Cut Off")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CutOff1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CutOff1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CutOff1( System.String reqCutOffUpdateIdentification,string reqCurrency,System.TimeOnly reqCutOffTime,System.String reqValueDateOffset )
    {
        CutOffUpdateIdentification = reqCutOffUpdateIdentification;
        Currency = reqCurrency;
        CutOffTime = reqCutOffTime;
        ValueDateOffset = reqValueDateOffset;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification for the updated netting cut off.
    /// </summary>
    [IsoId("_hrAdUZnoEeaKH-pm9fIa8w")]
    [DisplayName("Cut Off Update Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CutOffUpdId")]
    #endif
    [IsoXmlTag("CutOffUpdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CutOffUpdateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CutOffUpdateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CutOffUpdateIdentification { get; init; } 
    #else
    public System.String CutOffUpdateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency linked to the netting cut off.
    /// </summary>
    [IsoId("_yTThwZnnEeaKH-pm9fIa8w")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Cut off time value for the netting cut off.
    /// </summary>
    [IsoId("_tbaqUJVIEeaYkf5FCqYMeA")]
    [DisplayName("Cut Off Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CutOffTm")]
    #endif
    [IsoXmlTag("CutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime CutOffTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly CutOffTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly CutOffTime { get; init; } 
    #else
    public System.TimeOnly CutOffTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the offset in business days from the value date from which the netting cut off is to be applied.
    /// </summary>
    [IsoId("_V7THkJVLEeaYkf5FCqYMeA")]
    [DisplayName("Value Date Offset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDtOffset")]
    #endif
    [IsoXmlTag("ValDtOffset")]
    [IsoSimpleType(IsoSimpleType.DateOffsetText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDateOffsetText ValueDateOffset { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ValueDateOffset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ValueDateOffset { get; init; } 
    #else
    public System.String ValueDateOffset { get; set; } 
    #endif
    
    
    #nullable disable
    
}
