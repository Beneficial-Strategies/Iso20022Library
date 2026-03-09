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
/// Indicates the unadjusted effective and end date of the schedule.
/// </summary>
[IsoId("_evIKUQbIEeqrW7Meu5r3kQ")]
[DisplayName("Schedule")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Schedule2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Schedule2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Schedule2( System.DateOnly reqUnadjustedEffectiveDate,System.UInt64 reqQuantity )
    {
        UnadjustedEffectiveDate = reqUnadjustedEffectiveDate;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    [IsoId("_e3D-UQbIEeqrW7Meu5r3kQ")]
    [DisplayName("Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UadjstdFctvDt")]
    #endif
    [IsoXmlTag("UadjstdFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate UnadjustedEffectiveDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly UnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly UnadjustedEffectiveDate { get; init; } 
    #else
    public System.DateOnly UnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    [IsoId("_e3D-UwbIEeqrW7Meu5r3kQ")]
    [DisplayName("Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UadjstdEndDt")]
    #endif
    [IsoXmlTag("UadjstdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? UnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? UnadjustedEndDate { get; init; } 
    #else
    public System.DateOnly? UnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_e3D-VQbIEeqrW7Meu5r3kQ")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLongFraction19DecimalNumber Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Quantity { get; init; } 
    #else
    public System.UInt64 Quantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
