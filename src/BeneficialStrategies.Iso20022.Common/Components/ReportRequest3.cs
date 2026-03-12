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
[IsoId("_rRt3UQ1OEeqjM-rxn3HuXQ")]
[DisplayName("Report Request")]
public partial record ReportRequest3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_reo5AQ1OEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_reo5Aw1OEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_reo5BQ1OEeqjM-rxn3HuXQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService6Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the Transaction Report Request message.
    /// </summary>
    [IsoId("_reo5Bw1OEeqjM-rxn3HuXQ")]
    [DisplayName("Report Transaction Request")]
    [IsoXmlTag("RptTxReq")]
    public ReportTransactionRequest1? ReportTransactionRequest { get; init; } 
    
    /// <summary>
    /// Content of the Get Totals Request message.
    /// </summary>
    [IsoId("_reo5CQ1OEeqjM-rxn3HuXQ")]
    [DisplayName("Report Get Totals Request")]
    [IsoXmlTag("RptGetTtlsReq")]
    public ReportGetTotalsRequest1? ReportGetTotalsRequest { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_reo5Cw1OEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
