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
[IsoId("_SnKxcMRtEeij-rSPpvD-Tw")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement78
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement78 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement78( System.String reqStatementIdentification,DateAndDateTime2Choice_ reqStatementDateTime,Frequency22Choice_ reqFrequency,UpdateType15Choice_ reqUpdateType,CollateralRole1Code reqCollateralSide,StatementBasis14Choice_ reqStatementBasis,System.String reqSummaryIndicator,System.String reqActivityIndicator )
    {
        StatementIdentification = reqStatementIdentification;
        StatementDateTime = reqStatementDateTime;
        Frequency = reqFrequency;
        UpdateType = reqUpdateType;
        CollateralSide = reqCollateralSide;
        StatementBasis = reqStatementBasis;
        SummaryIndicator = reqSummaryIndicator;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_47krEcRuEeij-rSPpvD-Tw")]
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
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_0GkD9MRuEeij-rSPpvD-Tw")]
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
    [IsoId("_22HadMRuEeij-rSPpvD-Tw")]
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
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_7YOTtMRuEeij-rSPpvD-Tw")]
    [DisplayName("Statement Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtTm")]
    #endif
    [IsoXmlTag("StmtDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_ StatementDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("__jIN5MRuEeij-rSPpvD-Tw")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency22Choice_ Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency22Choice_ Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency22Choice_ Frequency { get; init; } 
    #else
    public Frequency22Choice_ Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_B7nvRMRvEeij-rSPpvD-Tw")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UpdateType15Choice_ UpdateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UpdateType15Choice_ UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdateType15Choice_ UpdateType { get; init; } 
    #else
    public UpdateType15Choice_ UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_dFvXMMRvEeij-rSPpvD-Tw")]
    [DisplayName("Collateral Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSd")]
    #endif
    [IsoXmlTag("CollSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralRole1Code CollateralSide { get; init; } 
    #else
    public CollateralRole1Code CollateralSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the basis on which the statement is prepared.
    /// </summary>
    [IsoId("_vd22oMRyEeij-rSPpvD-Tw")]
    [DisplayName("Statement Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtBsis")]
    #endif
    [IsoXmlTag("StmtBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementBasis14Choice_ StatementBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementBasis14Choice_ StatementBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementBasis14Choice_ StatementBasis { get; init; } 
    #else
    public StatementBasis14Choice_ StatementBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transactions reported are pending or confirmed.
    /// </summary>
    [IsoId("_F_VYwNBWEeiirviLm7P0IA")]
    [DisplayName("Status Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsTp")]
    #endif
    [IsoXmlTag("StsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementStatusType1Code? StatusType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementStatusType1Code? StatusType { get; init; } 
    #else
    public StatementStatusType1Code? StatusType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the report is a summary.
    /// If the indicator is set to Y then the report will not contain the securities or cash balances.
    /// If the indicator is set to N then the report will contain the securities or cash balances.
    /// </summary>
    [IsoId("_0-gEFLFBEeqMo4JxiuZGSw")]
    [DisplayName("Summary Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryInd")]
    #endif
    [IsoXmlTag("SummryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SummaryIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SummaryIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SummaryIndicator { get; init; } 
    #else
    public System.String SummaryIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_EmtchMRvEeij-rSPpvD-Tw")]
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
    
    
    #nullable disable
    
}
