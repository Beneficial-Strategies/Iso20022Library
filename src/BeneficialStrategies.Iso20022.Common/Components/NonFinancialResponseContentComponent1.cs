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
[IsoId("_KKDwkC_uEeugIJ3Gvoevmg")]
[DisplayName("Non Financial Response Content Component")]
public partial record NonFinancialResponseContentComponent1
{
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acquirer processed.
    /// </summary>
    [IsoId("_aO9-oS_uEeugIJ3Gvoevmg")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public required NonFinancialRequestType1Code NonFinancialRequestType { get; init; } 
    
    /// <summary>
    /// Identification of the most relevant Acquirer to process the transaction.
    /// </summary>
    [IsoId("_pJh5cC_uEeugIJ3Gvoevmg")]
    [DisplayName("Acquirer Selected")]
    [IsoXmlTag("AcqrrSelctd")]
    public Acquirer10? AcquirerSelected { get; init; } 
    
    /// <summary>
    /// Advice from the Acquirer (or its Agent) to the POI to manage risk. 
    /// </summary>
    [IsoId("_LaIxAC_xEeugIJ3Gvoevmg")]
    [DisplayName("Risk Management Result")]
    [IsoXmlTag("RskMgmtRslt")]
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_Se83kS_xEeugIJ3Gvoevmg")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action11? Action { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_YlVnAS_xEeugIJ3Gvoevmg")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    
    #nullable disable
    
}
