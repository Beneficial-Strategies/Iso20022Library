// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fraud reporting type information
/// </summary>
[IsoId("_CTB3kcVXEeuips4fuphvoQ")]
[DisplayName("Reported Fraud")]
public partial record ReportedFraud3
{
    #nullable enable
    
    /// <summary>
    /// Type of fraud for which a report is established.
    /// </summary>
    [IsoId("_CYltAcVXEeuips4fuphvoQ")]
    [DisplayName("Fraud Type")]
    [IsoXmlTag("FrdTp")]
    public required FraudType1Code FraudType { get; init; } 
    
    /// <summary>
    /// Other type of fraud.
    /// </summary>
    [IsoId("_CYltA8VXEeuips4fuphvoQ")]
    [DisplayName("Other Fraud Type")]
    [IsoXmlTag("OthrFrdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherFraudType { get; init; } 
    
    /// <summary>
    /// Identifies the type of reported fraudulent transaction.
    /// </summary>
    [IsoId("_CYltBcVXEeuips4fuphvoQ")]
    [DisplayName("Fraud Reporting Action")]
    [IsoXmlTag("FrdRptgActn")]
    public required FraudReportingAction1Code FraudReportingAction { get; init; } 
    
    /// <summary>
    /// Other fraud reporting action.
    /// </summary>
    [IsoId("_CYltB8VXEeuips4fuphvoQ")]
    [DisplayName("Other Fraud Reporting Action")]
    [IsoXmlTag("OthrFrdRptgActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherFraudReportingAction { get; init; } 
    
    /// <summary>
    /// Type of fraud reporting entity.
    /// </summary>
    [IsoId("_CYltCcVXEeuips4fuphvoQ")]
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required PartyType26Code ReportingEntity { get; init; } 
    
    /// <summary>
    /// Other type of fraud reporting entity.
    /// </summary>
    [IsoId("_CYltC8VXEeuips4fuphvoQ")]
    [DisplayName("Other Reporting Entity")]
    [IsoXmlTag("OthrRptgNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherReportingEntity { get; init; } 
    
    /// <summary>
    /// Identifies the type of cardholder credential that was compromised.
    /// </summary>
    [IsoId("_CYltDcVXEeuips4fuphvoQ")]
    [DisplayName("Compromised Credential")]
    [IsoXmlTag("CmprmsdCrdntl")]
    public AuthenticationMethod12Code? CompromisedCredential { get; init; } 
    
    /// <summary>
    /// Date of fraud as reported by the cardholder
    /// </summary>
    [IsoId("_CYltD8VXEeuips4fuphvoQ")]
    [DisplayName("Cardholder Reporting Date")]
    [IsoXmlTag("CrdhldrRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CardholderReportingDate { get; init; } 
    
    /// <summary>
    /// Date fraud was confirmed by the cardholder.
    /// </summary>
    [IsoId("_CYltEcVXEeuips4fuphvoQ")]
    [DisplayName("Confirmation Reporting Date")]
    [IsoXmlTag("ConfRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConfirmationReportingDate { get; init; } 
    
    /// <summary>
    /// Reference to the case as provided by the submitter.
    /// </summary>
    [IsoId("_CYltE8VXEeuips4fuphvoQ")]
    [DisplayName("Submitter Case Reference")]
    [IsoXmlTag("SubmitrCaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubmitterCaseReference { get; init; } 
    
    /// <summary>
    /// Details of fraudulent case.
    /// </summary>
    [IsoId("_CYltFcVXEeuips4fuphvoQ")]
    [DisplayName("Fraud Case Details")]
    [IsoXmlTag("FrdCaseDtls")]
    public FraudCaseDetails1? FraudCaseDetails { get; init; } 
    
    /// <summary>
    /// Status of submitter investigation at time of submission.
    /// </summary>
    [IsoId("_CYltF8VXEeuips4fuphvoQ")]
    [DisplayName("Fraud Investigation Status")]
    [IsoXmlTag("FrdInvstgtnSts")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? FraudInvestigationStatus { get; init; } 
    
    
    #nullable disable
    
}
