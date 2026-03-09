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
/// Provides the parameters of the report.
/// </summary>
[IsoId("_QlScZdp-Ed-ak6NoX_4Aeg_-2031836771")]
[DisplayName("Report Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportParameters4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportParameters4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportParameters4( System.String reqReportIdentification,DateAndDateTimeChoice_ reqReportDateAndTime )
    {
        ReportIdentification = reqReportIdentification;
        ReportDateAndTime = reqReportDateAndTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_QlScZtp-Ed-ak6NoX_4Aeg_-2013136855")]
    [DisplayName("Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptId")]
    #endif
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ReportIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReportIdentification { get; init; } 
    #else
    public System.String ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the report.
    /// </summary>
    [IsoId("_QlScZ9p-Ed-ak6NoX_4Aeg_-1387002249")]
    [DisplayName("Report Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDtAndTm")]
    #endif
    [IsoXmlTag("RptDtAndTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ ReportDateAndTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
