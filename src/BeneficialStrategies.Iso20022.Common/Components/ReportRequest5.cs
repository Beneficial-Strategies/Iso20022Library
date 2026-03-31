// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_9eR5cU6uEeyGi9JAv6wq7Q")]
[DisplayName("Report Request")]
public record ReportRequest5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_9lRSQU6uEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_9lRSQ06uEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_9lRSRU6uEeyGi9JAv6wq7Q")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService6Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Transaction Report Request message.
    /// </summary>
    [IsoId("_9lRSR06uEeyGi9JAv6wq7Q")]
    [DisplayName("Report Transaction Request")]
    [IsoXmlTag("RptTxReq")]
    public ReportTransactionRequest1? ReportTransactionRequest { get; init; }

    /// <summary>
    /// Content of the Get Totals Request message.
    /// </summary>
    [IsoId("_9lRSSU6uEeyGi9JAv6wq7Q")]
    [DisplayName("Report Get Totals Request")]
    [IsoXmlTag("RptGetTtlsReq")]
    public ReportGetTotalsRequest1? ReportGetTotalsRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_9lRSS06uEeyGi9JAv6wq7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
