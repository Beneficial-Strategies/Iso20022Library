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
[IsoId("_T5oiANp-Ed-ak6NoX_4Aeg_1497161223")]
[DisplayName("Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Period2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Period2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Period2( System.DateOnly reqFromDate,System.DateOnly reqToDate )
    {
        FromDate = reqFromDate;
        ToDate = reqToDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_T5oiAdp-Ed-ak6NoX_4Aeg_1497161242")]
    [DisplayName("From Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrDt")]
    #endif
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate FromDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly FromDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly FromDate { get; init; } 
    #else
    public System.DateOnly FromDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_T5oiAtp-Ed-ak6NoX_4Aeg_1497161560")]
    [DisplayName("To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToDt")]
    #endif
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ToDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ToDate { get; init; } 
    #else
    public System.DateOnly ToDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
