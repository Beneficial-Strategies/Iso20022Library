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
[IsoId("_sAb_QbX8EfCUZfsQO4rYeA")]
[DisplayName("Report Response9")]
public record ReportResponse9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_sBV-NbX8EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_sBV-O7X8EfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_sBV-QbX8EfCUZfsQO4rYeA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService7Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    [IsoId("_sBV-R7X8EfCUZfsQO4rYeA")]
    [DisplayName("Report Transaction Response")]
    [IsoXmlTag("RptTxRspn")]
    public ReportTransactionResponse8? ReportTransactionResponse { get; init; }

    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    [IsoId("_sBV-TbX8EfCUZfsQO4rYeA")]
    [DisplayName("Report Get Totals Response")]
    [IsoXmlTag("RptGetTtlsRspn")]
    public ReportGetTotalsResponse2? ReportGetTotalsResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_sBV-U7X8EfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_sBV-WbX8EfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
