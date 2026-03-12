// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial response.
/// </summary>
[IsoId("_JlplIXJNEe299ZbWCkdR_w")]
[DisplayName("Non Financial Response Content Component")]
public partial record NonFinancialResponseContentComponent3
{
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acquirer processed.
    /// </summary>
    [IsoId("_JsqzIXJNEe299ZbWCkdR_w")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public required NonFinancialRequestType2Code NonFinancialRequestType { get; init; } 
    
    /// <summary>
    /// Identification of the most relevant Acquirer to process the transaction.
    /// </summary>
    [IsoId("_JsqzI3JNEe299ZbWCkdR_w")]
    [DisplayName("Acquirer Selected")]
    [IsoXmlTag("AcqrrSelctd")]
    public Acquirer10? AcquirerSelected { get; init; } 
    
    /// <summary>
    /// Advice from the Acquirer (or its Agent) to the POI to manage risk. 
    /// </summary>
    [IsoId("_JsqzJXJNEe299ZbWCkdR_w")]
    [DisplayName("Risk Management Result")]
    [IsoXmlTag("RskMgmtRslt")]
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; } 
    
    /// <summary>
    /// Details of instalment supoported by the Service Provider.
    /// </summary>
    [IsoId("_Jpl0gHJOEe299ZbWCkdR_w")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction5? Instalment { get; init; } 
    
    /// <summary>
    /// Additional elements sent by the ServiceProvider which are not linked to payment.
    /// </summary>
    [IsoId("_6qrvwHJOEe299ZbWCkdR_w")]
    [DisplayName("Additional Response")]
    [IsoXmlTag("AddtlRspn")]
    public ExternallyDefinedData4? AdditionalResponse { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_JsqzJ3JNEe299ZbWCkdR_w")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action14? Action { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_JsqzKXJNEe299ZbWCkdR_w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    
    #nullable disable
    
}
