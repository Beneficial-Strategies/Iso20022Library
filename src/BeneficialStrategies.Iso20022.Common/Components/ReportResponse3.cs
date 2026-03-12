// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_yweH4Q1OEeqjM-rxn3HuXQ")]
[DisplayName("Report Response")]
public partial record ReportResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_y64BEQ1OEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_y64BEw1OEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_y64BFQ1OEeqjM-rxn3HuXQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService7Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    [IsoId("_y64BFw1OEeqjM-rxn3HuXQ")]
    [DisplayName("Report Transaction Response")]
    [IsoXmlTag("RptTxRspn")]
    public ReportTransactionResponse2? ReportTransactionResponse { get; init; } 
    
    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    [IsoId("_y64BGQ1OEeqjM-rxn3HuXQ")]
    [DisplayName("Report Get Totals Response")]
    [IsoXmlTag("RptGetTtlsRspn")]
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_y64BGw1OEeqjM-rxn3HuXQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_y64BHQ1OEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
