// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of admin service to be used with this message.
/// </summary>
[IsoId("_zXT14Si4Eeurkfo6MpvKDA")]
[DisplayName("Session Management Response")]
public partial record SessionManagementResponse4
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_zk8CMSi4Eeurkfo6MpvKDA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_zk8CMyi4Eeurkfo6MpvKDA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_zk8CNSi4Eeurkfo6MpvKDA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService5Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    [IsoId("_zk8CNyi4Eeurkfo6MpvKDA")]
    [DisplayName("Login Response")]
    [IsoXmlTag("LgnRspn")]
    public LoginResponse3? LoginResponse { get; init; } 
    
    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    [IsoId("_zk8COSi4Eeurkfo6MpvKDA")]
    [DisplayName("Diagnosis Response")]
    [IsoXmlTag("DgnssRspn")]
    public DiagnosisResponse3? DiagnosisResponse { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_zk8COyi4Eeurkfo6MpvKDA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_zk8CPSi4Eeurkfo6MpvKDA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
