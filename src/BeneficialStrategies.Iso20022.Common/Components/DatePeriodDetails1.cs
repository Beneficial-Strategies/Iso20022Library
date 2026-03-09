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
[IsoId("_T-1yKNp-Ed-ak6NoX_4Aeg_-1267403940")]
[DisplayName("Date Period Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DatePeriodDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DatePeriodDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DatePeriodDetails1( System.DateOnly reqFromDate )
    {
        FromDate = reqFromDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_T-_jINp-Ed-ak6NoX_4Aeg_-1267403939")]
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
    /// End date of the range.
    /// </summary>
    [IsoId("_T-_jIdp-Ed-ak6NoX_4Aeg_-1267403938")]
    [DisplayName("To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToDt")]
    #endif
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ToDate { get; init; } 
    #else
    public System.DateOnly? ToDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
