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
[IsoId("_g59rYS5LEeunNvJlR_vCbg")]
[DisplayName("Report Response")]
public record ReportResponse4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_hIRNIS5LEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_hIRNIy5LEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_hIRNJS5LEeunNvJlR_vCbg")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService7Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    [IsoId("_hIRNJy5LEeunNvJlR_vCbg")]
    [DisplayName("Report Transaction Response")]
    [IsoXmlTag("RptTxRspn")]
    public ReportTransactionResponse3? ReportTransactionResponse { get; init; }

    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    [IsoId("_hIRNKS5LEeunNvJlR_vCbg")]
    [DisplayName("Report Get Totals Response")]
    [IsoXmlTag("RptGetTtlsRspn")]
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_hIRNKy5LEeunNvJlR_vCbg")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_hIRNLS5LEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
