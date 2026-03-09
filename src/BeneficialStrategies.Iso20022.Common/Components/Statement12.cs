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
/// General characteristics related to a statement which reports information.
/// </summary>
[IsoId("_QxgTctp-Ed-ak6NoX_4Aeg_-1743572610")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement12( CorporateActionStatementType1Code reqStatementType,CorporateActionStatementReportingType1Code reqReportingType,System.String reqStatementIdentification,DateAndDateTimeChoice_ reqStatementDateTime,Frequency4Choice_ reqFrequency,UpdateType2Choice_ reqUpdateType,System.String reqActivityIndicator )
    {
        StatementType = reqStatementType;
        ReportingType = reqReportingType;
        StatementIdentification = reqStatementIdentification;
        StatementDateTime = reqStatementDateTime;
        Frequency = reqFrequency;
        UpdateType = reqUpdateType;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    [IsoId("_QxgTc9p-Ed-ak6NoX_4Aeg_-1695550125")]
    [DisplayName("Statement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtTp")]
    #endif
    [IsoXmlTag("StmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionStatementType1Code StatementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionStatementType1Code StatementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionStatementType1Code StatementType { get; init; } 
    #else
    public CorporateActionStatementType1Code StatementType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_QxgTdNp-Ed-ak6NoX_4Aeg_1236770237")]
    [DisplayName("Reporting Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgTp")]
    #endif
    [IsoXmlTag("RptgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    #else
    public CorporateActionStatementReportingType1Code ReportingType { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_QxgTddp-Ed-ak6NoX_4Aeg_-1743572330")]
    [DisplayName("Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtId")]
    #endif
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text StatementIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatementIdentification { get; init; } 
    #else
    public System.String StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_QxgTdtp-Ed-ak6NoX_4Aeg_-1743571815")]
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
    /// Date of the statement.
    /// </summary>
    [IsoId("_QxgTd9p-Ed-ak6NoX_4Aeg_-1743572240")]
    [DisplayName("Statement Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtTm")]
    #endif
    [IsoXmlTag("StmtDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ StatementDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QxgTeNp-Ed-ak6NoX_4Aeg_-1743572209")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency4Choice_ Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency4Choice_ Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency4Choice_ Frequency { get; init; } 
    #else
    public Frequency4Choice_ Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_QxqEcNp-Ed-ak6NoX_4Aeg_-1743572148")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UpdateType2Choice_ UpdateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UpdateType2Choice_ UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdateType2Choice_ UpdateType { get; init; } 
    #else
    public UpdateType2Choice_ UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QxqEcdp-Ed-ak6NoX_4Aeg_-1743572117")]
    [DisplayName("Activity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyInd")]
    #endif
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ActivityIndicator { get; init; } 
    #else
    public System.String ActivityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_QxqEctp-Ed-ak6NoX_4Aeg_940178444")]
    [DisplayName("Notification Deadline Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnDdlnPrd")]
    #endif
    [IsoXmlTag("NtfctnDdlnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrDateTimePeriodChoice_? NotificationDeadlinePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrDateTimePeriodChoice_? NotificationDeadlinePeriod { get; init; } 
    #else
    public DateOrDateTimePeriodChoice_? NotificationDeadlinePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
