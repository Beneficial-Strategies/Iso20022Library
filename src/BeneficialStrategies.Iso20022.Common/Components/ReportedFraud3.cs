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
/// Fraud reporting type information
/// </summary>
[IsoId("_CTB3kcVXEeuips4fuphvoQ")]
[DisplayName("Reported Fraud")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportedFraud3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportedFraud3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportedFraud3( FraudType1Code reqFraudType,FraudReportingAction1Code reqFraudReportingAction,PartyType26Code reqReportingEntity )
    {
        FraudType = reqFraudType;
        FraudReportingAction = reqFraudReportingAction;
        ReportingEntity = reqReportingEntity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of fraud for which a report is established.
    /// </summary>
    [IsoId("_CYltAcVXEeuips4fuphvoQ")]
    [DisplayName("Fraud Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdTp")]
    #endif
    [IsoXmlTag("FrdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudType1Code FraudType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudType1Code FraudType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudType1Code FraudType { get; init; } 
    #else
    public FraudType1Code FraudType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of fraud.
    /// </summary>
    [IsoId("_CYltA8VXEeuips4fuphvoQ")]
    [DisplayName("Other Fraud Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFrdTp")]
    #endif
    [IsoXmlTag("OthrFrdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFraudType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFraudType { get; init; } 
    #else
    public System.String? OtherFraudType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of reported fraudulent transaction.
    /// </summary>
    [IsoId("_CYltBcVXEeuips4fuphvoQ")]
    [DisplayName("Fraud Reporting Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdRptgActn")]
    #endif
    [IsoXmlTag("FrdRptgActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudReportingAction1Code FraudReportingAction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudReportingAction1Code FraudReportingAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudReportingAction1Code FraudReportingAction { get; init; } 
    #else
    public FraudReportingAction1Code FraudReportingAction { get; set; } 
    #endif
    
    /// <summary>
    /// Other fraud reporting action.
    /// </summary>
    [IsoId("_CYltB8VXEeuips4fuphvoQ")]
    [DisplayName("Other Fraud Reporting Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFrdRptgActn")]
    #endif
    [IsoXmlTag("OthrFrdRptgActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFraudReportingAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFraudReportingAction { get; init; } 
    #else
    public System.String? OtherFraudReportingAction { get; set; } 
    #endif
    
    /// <summary>
    /// Type of fraud reporting entity.
    /// </summary>
    [IsoId("_CYltCcVXEeuips4fuphvoQ")]
    [DisplayName("Reporting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgNtty")]
    #endif
    [IsoXmlTag("RptgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyType26Code ReportingEntity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyType26Code ReportingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType26Code ReportingEntity { get; init; } 
    #else
    public PartyType26Code ReportingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of fraud reporting entity.
    /// </summary>
    [IsoId("_CYltC8VXEeuips4fuphvoQ")]
    [DisplayName("Other Reporting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRptgNtty")]
    #endif
    [IsoXmlTag("OthrRptgNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherReportingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherReportingEntity { get; init; } 
    #else
    public System.String? OtherReportingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of cardholder credential that was compromised.
    /// </summary>
    [IsoId("_CYltDcVXEeuips4fuphvoQ")]
    [DisplayName("Compromised Credential")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmprmsdCrdntl")]
    #endif
    [IsoXmlTag("CmprmsdCrdntl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationMethod12Code? CompromisedCredential { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod12Code? CompromisedCredential { get; init; } 
    #else
    public AuthenticationMethod12Code? CompromisedCredential { get; set; } 
    #endif
    
    /// <summary>
    /// Date of fraud as reported by the cardholder
    /// </summary>
    [IsoId("_CYltD8VXEeuips4fuphvoQ")]
    [DisplayName("Cardholder Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrRptgDt")]
    #endif
    [IsoXmlTag("CrdhldrRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CardholderReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CardholderReportingDate { get; init; } 
    #else
    public System.DateOnly? CardholderReportingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date fraud was confirmed by the cardholder.
    /// </summary>
    [IsoId("_CYltEcVXEeuips4fuphvoQ")]
    [DisplayName("Confirmation Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfRptgDt")]
    #endif
    [IsoXmlTag("ConfRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ConfirmationReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ConfirmationReportingDate { get; init; } 
    #else
    public System.DateOnly? ConfirmationReportingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the case as provided by the submitter.
    /// </summary>
    [IsoId("_CYltE8VXEeuips4fuphvoQ")]
    [DisplayName("Submitter Case Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrCaseRef")]
    #endif
    [IsoXmlTag("SubmitrCaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubmitterCaseReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubmitterCaseReference { get; init; } 
    #else
    public System.String? SubmitterCaseReference { get; set; } 
    #endif
    
    /// <summary>
    /// Details of fraudulent case.
    /// </summary>
    [IsoId("_CYltFcVXEeuips4fuphvoQ")]
    [DisplayName("Fraud Case Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdCaseDtls")]
    #endif
    [IsoXmlTag("FrdCaseDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FraudCaseDetails1? FraudCaseDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudCaseDetails1? FraudCaseDetails { get; init; } 
    #else
    public FraudCaseDetails1? FraudCaseDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Status of submitter investigation at time of submission.
    /// </summary>
    [IsoId("_CYltF8VXEeuips4fuphvoQ")]
    [DisplayName("Fraud Investigation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdInvstgtnSts")]
    #endif
    [IsoXmlTag("FrdInvstgtnSts")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? FraudInvestigationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FraudInvestigationStatus { get; init; } 
    #else
    public System.String? FraudInvestigationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
