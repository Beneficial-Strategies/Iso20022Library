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
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_6T03GpqlEeGSON8vddiWzQ_1589848859")]
[DisplayName("Date Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DatePeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DatePeriod1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DatePeriod1( System.DateOnly reqToDate )
    {
        ToDate = reqToDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_6T03G5qlEeGSON8vddiWzQ_2053251952")]
    [DisplayName("From Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrDt")]
    #endif
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FromDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FromDate { get; init; } 
    #else
    public System.DateOnly? FromDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_6T03HJqlEeGSON8vddiWzQ_-1787628075")]
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
