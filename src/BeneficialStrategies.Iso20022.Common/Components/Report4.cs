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
/// General characteristics of the report.
/// </summary>
[IsoId("_m_exhfNBEeCuA5Tr22BnwA_1065800194")]
[DisplayName("Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Report4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Report4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Report4( DateAndDateTimeChoice_ reqReportDateTime,Frequency8Choice_ reqFrequency,UpdateType4Choice_ reqUpdateType,StatementBasis6Choice_ reqReportBasis )
    {
        ReportDateTime = reqReportDateTime;
        Frequency = reqFrequency;
        UpdateType = reqUpdateType;
        ReportBasis = reqReportBasis;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_m_exhvNBEeCuA5Tr22BnwA_1065800718")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportNumber { get; init; } 
    #else
    public System.String? ReportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_m_exh_NBEeCuA5Tr22BnwA_2072309707")]
    [DisplayName("Query Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRef")]
    #endif
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryReference { get; init; } 
    #else
    public System.String? QueryReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_m_exiPNBEeCuA5Tr22BnwA_1065800233")]
    [DisplayName("Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptId")]
    #endif
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportIdentification { get; init; } 
    #else
    public System.String? ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the report.
    /// </summary>
    [IsoId("_m_exifNBEeCuA5Tr22BnwA_1065800255")]
    [DisplayName("Report Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDtTm")]
    #endif
    [IsoXmlTag("RptDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ ReportDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ ReportDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ ReportDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ ReportDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Preparation date and time of the report.
    /// </summary>
    [IsoId("_m_oigPNBEeCuA5Tr22BnwA_1065800317")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? CreationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Previous report date and time.
    /// </summary>
    [IsoId("_m_oigfNBEeCuA5Tr22BnwA_552028722")]
    [DisplayName("Previous Report Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRptDtTm")]
    #endif
    [IsoXmlTag("PrvsRptDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? PreviousReportDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? PreviousReportDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? PreviousReportDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of the report.
    /// </summary>
    [IsoId("_m_oigvNBEeCuA5Tr22BnwA_1065800347")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency8Choice_ Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency8Choice_ Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency8Choice_ Frequency { get; init; } 
    #else
    public Frequency8Choice_ Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_m_oig_NBEeCuA5Tr22BnwA_1065800378")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UpdateType4Choice_ UpdateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UpdateType4Choice_ UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdateType4Choice_ UpdateType { get; init; } 
    #else
    public UpdateType4Choice_ UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of balance on which the report is prepared.
    /// </summary>
    [IsoId("_m_oihPNBEeCuA5Tr22BnwA_1065800717")]
    [DisplayName("Report Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptBsis")]
    #endif
    [IsoXmlTag("RptBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementBasis6Choice_ ReportBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementBasis6Choice_ ReportBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementBasis6Choice_ ReportBasis { get; init; } 
    #else
    public StatementBasis6Choice_ ReportBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Period for which the report is given.
    /// </summary>
    [IsoId("_m_oihfNBEeCuA5Tr22BnwA_1663646731")]
    [DisplayName("Report Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptPrd")]
    #endif
    [IsoXmlTag("RptPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodDetails? ReportPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodDetails? ReportPeriod { get; init; } 
    #else
    public DatePeriodDetails? ReportPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the source of the report.
    /// </summary>
    [IsoId("_m_oihvNBEeCuA5Tr22BnwA_1090015501")]
    [DisplayName("Report Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSrc")]
    #endif
    [IsoXmlTag("RptSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementSource1Choice_? ReportSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementSource1Choice_? ReportSource { get; init; } 
    #else
    public StatementSource1Choice_? ReportSource { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the report is audited or not.
    /// </summary>
    [IsoId("_m_xscPNBEeCuA5Tr22BnwA_1065800748")]
    [DisplayName("Audited Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AudtdInd")]
    #endif
    [IsoXmlTag("AudtdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AuditedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuditedIndicator { get; init; } 
    #else
    public System.String? AuditedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or an information update reported in the report.
    /// </summary>
    [IsoId("_m_xscfNBEeCuA5Tr22BnwA_1065800439")]
    [DisplayName("Activity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyInd")]
    #endif
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ActivityIndicator { get; init; } 
    #else
    public System.String? ActivityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
