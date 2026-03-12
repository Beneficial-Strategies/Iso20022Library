// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of admin service to be used with this message.
/// </summary>
[IsoId("_-MpCUXJIEe299ZbWCkdR_w")]
[DisplayName("Session Management Response")]
public partial record SessionManagementResponse6
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_-TfRMXJIEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_-TfRM3JIEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_-TfRNXJIEe299ZbWCkdR_w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService5Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    [IsoId("_-TfRN3JIEe299ZbWCkdR_w")]
    [DisplayName("Login Response")]
    [IsoXmlTag("LgnRspn")]
    public LoginResponse5? LoginResponse { get; init; } 
    
    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    [IsoId("_-TfROXJIEe299ZbWCkdR_w")]
    [DisplayName("Diagnosis Response")]
    [IsoXmlTag("DgnssRspn")]
    public DiagnosisResponse5? DiagnosisResponse { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_-TfRO3JIEe299ZbWCkdR_w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_-TfRPXJIEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
