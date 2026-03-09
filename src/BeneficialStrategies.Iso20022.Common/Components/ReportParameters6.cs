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
/// Parameters of the report.
/// </summary>
[IsoId("_MSIRAAynEeukOZYTbzKKxw")]
[DisplayName("Report Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportParameters6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportParameters6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportParameters6( System.String reqReportIdentification,DateAndDateTime2Choice_ reqReportDateAndTime,EventFrequency6Code reqFrequency,string reqReportCurrency )
    {
        ReportIdentification = reqReportIdentification;
        ReportDateAndTime = reqReportDateAndTime;
        Frequency = reqFrequency;
        ReportCurrency = reqReportCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_MSIRBAynEeukOZYTbzKKxw")]
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
    /// Date (and time) at which the report was created.
    /// </summary>
    [IsoId("_MSIRAwynEeukOZYTbzKKxw")]
    [DisplayName("Report Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDtAndTm")]
    #endif
    [IsoXmlTag("RptDtAndTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ ReportDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ ReportDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ ReportDateAndTime { get; init; } 
    #else
    public DateAndDateTime2Choice_ ReportDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_MSIRBQynEeukOZYTbzKKxw")]
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
    /// Currency used for the calculation of the guarantee fund.
    /// </summary>
    [IsoId("_MSIRAQynEeukOZYTbzKKxw")]
    [DisplayName("Report Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptCcy")]
    #endif
    [IsoXmlTag("RptCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode ReportCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ReportCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ReportCurrency { get; init; } 
    #else
    public string ReportCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Date of calculation of the deficit (if any).
    /// </summary>
    [IsoId("_MSIRAgynEeukOZYTbzKKxw")]
    [DisplayName("Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnDt")]
    #endif
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CalculationDate { get; init; } 
    #else
    public System.DateTime? CalculationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
