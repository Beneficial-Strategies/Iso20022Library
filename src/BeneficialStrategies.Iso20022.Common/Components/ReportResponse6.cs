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
[IsoId("_nAqyUXJFEe299ZbWCkdR_w")]
[DisplayName("Report Response")]
public record ReportResponse6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_nHtOcXJFEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_nHtOc3JFEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_nHtOdXJFEe299ZbWCkdR_w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService7Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    [IsoId("_nHtOd3JFEe299ZbWCkdR_w")]
    [DisplayName("Report Transaction Response")]
    [IsoXmlTag("RptTxRspn")]
    public ReportTransactionResponse5? ReportTransactionResponse { get; init; }

    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    [IsoId("_nHtOeXJFEe299ZbWCkdR_w")]
    [DisplayName("Report Get Totals Response")]
    [IsoXmlTag("RptGetTtlsRspn")]
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_nHtOe3JFEe299ZbWCkdR_w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_nHtOfXJFEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
