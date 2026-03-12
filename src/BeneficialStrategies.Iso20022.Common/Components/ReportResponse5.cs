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
[IsoId("_0zfHIU07Eeybj420QgWBkA")]
[DisplayName("Report Response")]
public partial record ReportResponse5
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_058UcU07Eeybj420QgWBkA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_058Uc007Eeybj420QgWBkA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_058UdU07Eeybj420QgWBkA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService7Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    [IsoId("_058Ud007Eeybj420QgWBkA")]
    [DisplayName("Report Transaction Response")]
    [IsoXmlTag("RptTxRspn")]
    public ReportTransactionResponse4? ReportTransactionResponse { get; init; } 
    
    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    [IsoId("_058UeU07Eeybj420QgWBkA")]
    [DisplayName("Report Get Totals Response")]
    [IsoXmlTag("RptGetTtlsRspn")]
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_058Ue007Eeybj420QgWBkA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_058UfU07Eeybj420QgWBkA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
