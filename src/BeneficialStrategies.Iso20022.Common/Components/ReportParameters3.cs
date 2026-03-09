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
[IsoId("_QlScaNp-Ed-ak6NoX_4Aeg_1048103905")]
[DisplayName("Report Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportParameters3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportParameters3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportParameters3( System.String reqReportIdentification,DateAndDateTimeChoice_ reqReportDateAndTime,string reqReportCurrency,System.DateTime reqCalculationDateAndTime,EventFrequency6Code reqFrequency )
    {
        ReportIdentification = reqReportIdentification;
        ReportDateAndTime = reqReportDateAndTime;
        ReportCurrency = reqReportCurrency;
        CalculationDateAndTime = reqCalculationDateAndTime;
        Frequency = reqFrequency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_QlcNYNp-Ed-ak6NoX_4Aeg_928215481")]
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
    /// Date (and time) and time of the report.
    /// </summary>
    [IsoId("_QlcNYdp-Ed-ak6NoX_4Aeg_-419897874")]
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
    
    /// <summary>
    /// Currency used for the calculation of the margin.
    /// </summary>
    [IsoId("_QlcNYtp-Ed-ak6NoX_4Aeg_-336611287")]
    [DisplayName("Report Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptCcy")]
    #endif
    [IsoXmlTag("RptCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode ReportCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ReportCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ReportCurrency { get; init; } 
    #else
    public string ReportCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Date of calculation of the margin.
    /// </summary>
    [IsoId("_QlcNY9p-Ed-ak6NoX_4Aeg_-1305521230")]
    [DisplayName("Calculation Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnDtAndTm")]
    #endif
    [IsoXmlTag("ClctnDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CalculationDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CalculationDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CalculationDateAndTime { get; init; } 
    #else
    public System.DateTime CalculationDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_QlcNZNp-Ed-ak6NoX_4Aeg_594389524")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventFrequency6Code Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventFrequency6Code Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency6Code Frequency { get; init; } 
    #else
    public EventFrequency6Code Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_QlcNZdp-Ed-ak6NoX_4Aeg_-1126454468")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact5NumericText? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportNumber { get; init; } 
    #else
    public System.String? ReportNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
