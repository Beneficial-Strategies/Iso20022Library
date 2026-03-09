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
/// Characteristics of the statement.
/// </summary>
[IsoId("_Qp52ptp-Ed-ak6NoX_4Aeg_400350199")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement20( DateAndDateTimeChoice_ reqStatementDateTime,Frequency4Choice_ reqFrequency,UpdateType2Choice_ reqUpdateType,StatementBasis3Choice_ reqStatementBasis,System.String reqActivityIndicator,System.String reqAuditedIndicator,System.String reqSubAccountIndicator )
    {
        StatementDateTime = reqStatementDateTime;
        Frequency = reqFrequency;
        UpdateType = reqUpdateType;
        StatementBasis = reqStatementBasis;
        ActivityIndicator = reqActivityIndicator;
        AuditedIndicator = reqAuditedIndicator;
        SubAccountIndicator = reqSubAccountIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_Qp52p9p-Ed-ak6NoX_4Aeg_-710561220")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number3Choice_? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number3Choice_? ReportNumber { get; init; } 
    #else
    public Number3Choice_? ReportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_Qp52qNp-Ed-ak6NoX_4Aeg_286511133")]
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
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_Qp52qdp-Ed-ak6NoX_4Aeg_-1707633573")]
    [DisplayName("Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtId")]
    #endif
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatementIdentification { get; init; } 
    #else
    public System.String? StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_QqDnoNp-Ed-ak6NoX_4Aeg_1590261370")]
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
    [IsoId("_QqDnodp-Ed-ak6NoX_4Aeg_-1821956770")]
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
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QqDnotp-Ed-ak6NoX_4Aeg_-1935795836")]
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
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_QqDno9p-Ed-ak6NoX_4Aeg_1362099107")]
    [DisplayName("Statement Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtBsis")]
    #endif
    [IsoXmlTag("StmtBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementBasis3Choice_ StatementBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementBasis3Choice_ StatementBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementBasis3Choice_ StatementBasis { get; init; } 
    #else
    public StatementBasis3Choice_ StatementBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QqDnpNp-Ed-ak6NoX_4Aeg_1475938173")]
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
    /// Indicates whether the statement is audited or not.
    /// </summary>
    [IsoId("_QqDnpdp-Ed-ak6NoX_4Aeg_478865820")]
    [DisplayName("Audited Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AudtdInd")]
    #endif
    [IsoXmlTag("AudtdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AuditedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AuditedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AuditedIndicator { get; init; } 
    #else
    public System.String AuditedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_QqDnptp-Ed-ak6NoX_4Aeg_-582425320")]
    [DisplayName("Sub Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctInd")]
    #endif
    [IsoXmlTag("SubAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SubAccountIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SubAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SubAccountIndicator { get; init; } 
    #else
    public System.String SubAccountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement contains tax lot details.
    /// </summary>
    [IsoId("_QqDnp9p-Ed-ak6NoX_4Aeg_365026754")]
    [DisplayName("Tax Lot Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxLotInd")]
    #endif
    [IsoXmlTag("TaxLotInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TaxLotIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxLotIndicator { get; init; } 
    #else
    public System.String? TaxLotIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
