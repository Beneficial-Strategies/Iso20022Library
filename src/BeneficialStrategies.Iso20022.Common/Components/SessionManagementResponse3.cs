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
[IsoId("_RlB9EQ1WEeqjM-rxn3HuXQ")]
[DisplayName("Session Management Response")]
public partial record SessionManagementResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_RwjQkQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_RwjQkw1WEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_RwjQlQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService5Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    [IsoId("_RwjQlw1WEeqjM-rxn3HuXQ")]
    [DisplayName("Login Response")]
    [IsoXmlTag("LgnRspn")]
    public LoginResponse2? LoginResponse { get; init; } 
    
    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    [IsoId("_RwjQmQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Diagnosis Response")]
    [IsoXmlTag("DgnssRspn")]
    public DiagnosisResponse2? DiagnosisResponse { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_RwjQmw1WEeqjM-rxn3HuXQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_RwjQnQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
