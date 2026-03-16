// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_6PYB4XJQEe299ZbWCkdR_w")]
[DisplayName("Report Request")]
public record ReportRequest6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_6WogcXJQEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_6Wogc3JQEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_6WogdXJQEe299ZbWCkdR_w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService6Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Transaction Report Request message.
    /// </summary>
    [IsoId("_6Wogd3JQEe299ZbWCkdR_w")]
    [DisplayName("Report Transaction Request")]
    [IsoXmlTag("RptTxReq")]
    public ReportTransactionRequest1? ReportTransactionRequest { get; init; }

    /// <summary>
    /// Content of the Get Totals Request message.
    /// </summary>
    [IsoId("_6WogeXJQEe299ZbWCkdR_w")]
    [DisplayName("Report Get Totals Request")]
    [IsoXmlTag("RptGetTtlsReq")]
    public ReportGetTotalsRequest1? ReportGetTotalsRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_6Woge3JQEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
