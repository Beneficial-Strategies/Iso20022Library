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
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_JLNw0a3NEeey8N0JWnVPUw")]
[DisplayName("Date Time Period Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DateTimePeriodDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DateTimePeriodDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DateTimePeriodDetails2( System.DateTime reqFromDateTime,System.DateTime reqToDateTime )
    {
        FromDateTime = reqFromDateTime;
        ToDateTime = reqToDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_JWX38a3NEeey8N0JWnVPUw")]
    [DisplayName("From Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrDtTm")]
    #endif
    [IsoXmlTag("FrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime FromDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime FromDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime FromDateTime { get; init; } 
    #else
    public System.DateTime FromDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_JWX3863NEeey8N0JWnVPUw")]
    [DisplayName("To Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToDtTm")]
    #endif
    [IsoXmlTag("ToDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ToDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ToDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ToDateTime { get; init; } 
    #else
    public System.DateTime ToDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
