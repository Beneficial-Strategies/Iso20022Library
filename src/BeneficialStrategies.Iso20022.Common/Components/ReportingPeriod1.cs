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
/// Specifies the requested reporting period.
/// </summary>
[IsoId("_T57c9dp-Ed-ak6NoX_4Aeg_566244316")]
[DisplayName("Reporting Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportingPeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportingPeriod1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportingPeriod1( DatePeriodDetails1 reqFromToDate,TimePeriodDetails1 reqFromToTime,QueryType3Code reqType )
    {
        FromToDate = reqFromToDate;
        FromToTime = reqFromToTime;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies a date range.
    /// </summary>
    [IsoId("_T57c9tp-Ed-ak6NoX_4Aeg_566244351")]
    [DisplayName("From To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrToDt")]
    #endif
    [IsoXmlTag("FrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DatePeriodDetails1 FromToDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DatePeriodDetails1 FromToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodDetails1 FromToDate { get; init; } 
    #else
    public DatePeriodDetails1 FromToDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a time range.
    /// </summary>
    [IsoId("_T57c99p-Ed-ak6NoX_4Aeg_-966470712")]
    [DisplayName("From To Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrToTm")]
    #endif
    [IsoXmlTag("FrToTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TimePeriodDetails1 FromToTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TimePeriodDetails1 FromToTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimePeriodDetails1 FromToTime { get; init; } 
    #else
    public TimePeriodDetails1 FromToTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether all matching items need to be reported or only those items that are new or have changed since the last similar request was made.
    /// </summary>
    [IsoId("_T57c-Np-Ed-ak6NoX_4Aeg_-303042847")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QueryType3Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QueryType3Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QueryType3Code Type { get; init; } 
    #else
    public QueryType3Code Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
